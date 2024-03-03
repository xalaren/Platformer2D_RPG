using System;
using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class GameCore
    {
        private int maxY = 96;  
        private int maxX = 90;  
        private int accel = 3; 
        private int forceY = 12;
        private int forceX = 10; 
        private int deltaY = 0; 
        private int deltaX = 0; 
        private int throwForce = 3;  

        public int ReloadTime { get; set; }  
        public uint JumpsCount { get; set; } 
        public uint DashCount { get; set; }  
        public uint ShootCount { get; set; } 

        public enum Directions 
        {
            Left,
            Right
        }

        public enum Actions 
        {
            MoveLeft,
            MoveRight,
            Jump,
            Dash,
            Shoot
        }

        public enum Bounds 
        {
            Top,
            Bottom,
            Left,
            Right
        }

        public Player player;
        public Ground ground;
        public Frame frame;
        public PlatformController platformController;
        public SpikeController spikeController;
        public XPBlockController xpBlockController;
        public EntityController entityController;
        public FireballController fireballController;
        public LevelEndBlock levelEndBlock;

        public GameCore()
        {
            frame = new Frame(800, 600);
            ground = new Ground(0, frame.Height - 100, 800, 200);

            Size playerSize = new Size(26, 32);
            player = new Player(Level.SpawnPoint.X, Level.SpawnPoint.Y - playerSize.Height - 1, playerSize.Width, playerSize.Height);

            if (Level.TempLivesAmount > 0)
            {
                player.LivesAmount = Level.TempLivesAmount;
            }

            platformController = new PlatformController();
            spikeController = new SpikeController();
            entityController = new EntityController();
            xpBlockController = new XPBlockController();
            levelEndBlock = new LevelEndBlock(Level.LevelEndPoint.X, Level.LevelEndPoint.Y, frame.Width);
            fireballController = new FireballController();

            JumpsCount = 0;
            DashCount = 0;
            ShootCount = 0;

            player.ExpCountChanged += OnExpCountChanged;
            player.DirectionChanged += OnPlayerDirectionChanged;
        }

        #region Методы для связки с классами
        public void LinkGameCore()
        {
            GravityForceCalculate();
            MovePlayer(Directions.Left);
            MovePlayer(Directions.Right);
            AddForce();
            CollectXP();
            ThrowPlayer();
            Dash();

            entityController.MoveEntity();
            MoveFireball();

            EntityCollisionCheck();

            if (LevelCompare() || Level.XPCount == 0)
            {
                LevelExit();
            }
        }

        public void AllowActions(Actions action)
        {
            switch (action)
            {
                case Actions.MoveLeft:
                    player.IsMovingLeft = true;
                    player.IsMovingRight = false;
                    break;
                case Actions.MoveRight:
                    player.IsMovingRight = true;
                    player.IsMovingLeft = false;
                    break;
                case Actions.Jump:
                    if ((!player.IsFalling || player.CanDoubleJump) 
                        && JumpsCount < 1)
                    {
                        JumpsCount++;
                        player.IsJumping = true;
                    }
                    break;
                case Actions.Dash:
                    if (player.CanDash)
                    {
                        if (DashCount < 1)
                        {
                            DashCount++;
                            player.IsDashing = true;
                        }
                    }
                    break;
            }
        }

        public void DisableActions(Actions action)
        {
            switch (action)
            {
                case Actions.MoveLeft:
                    player.IsMovingLeft = false;
                    break;
                case Actions.MoveRight:
                    player.IsMovingRight = false;
                    break;
                case Actions.Dash:
                    if (player.CanDash)
                    {
                        player.IsDashing = false;
                    }
                    break;
                case Actions.Shoot:
                    if (player.CanShoot)
                    {
                        ShootFireball();
                    }
                    break;
            }
        }
        #endregion

        #region Физика игрока
        public void MovePlayer(Directions direction)
        {
            switch (direction)
            {
                case (Directions.Left):
                    if (player.IsMovingLeft)
                    {
                        if (!CollidePlatform(player) && !CollideSpike(player))
                        {
                            player.Direction = (sbyte)((-1) * Math.Abs(player.Direction));
                            player.X += player.Direction * player.Speed;
                        }
                        else if (CollideSpike(player))
                        {
                            SetOnSpawnPoint();
                            Damage();
                        }
                    }
                    break;
                case (Directions.Right):
                    if (player.IsMovingRight)
                    {
                        if (!CollidePlatform(player) && !CollideSpike(player))
                        {
                            player.Direction = Math.Abs(player.Direction);
                            player.X += player.Direction * player.Speed;
                        }
                        else if (CollideSpike(player))
                        {
                            Damage();
                        }
                    }
                    break;
            }
        }

        public void ThrowPlayer()
        {
            if (CollidePlatform(player))
            {
                player.X -= player.Direction * throwForce;
            }

            if (CollideFrame(Bounds.Left, player))
            {
                player.X += throwForce;
            }

            if (CollideFrame(Bounds.Right, player))
            {
                player.X -= throwForce;
            }
        }

        public void SetOnSpawnPoint()
        {
            player.X = Level.SpawnPoint.X;
            player.Y = Level.SpawnPoint.Y - player.Height - 1;
        }

        public void GravityForceCalculate()
        {
            if (!CollideLine() && !CollideGround() && !CollideSpike(player) && !player.IsDashing)
            {
                player.IsFalling = true;
                player.Y += accel;
            }
            else if (player.IsFalling && CollideSpike(player))
            {
                player.IsFalling = false;
                Damage();
            }
            else if (!player.IsDashing)
            {
                player.IsFalling = false;
                JumpsCount = 0;
                DashCount = 0;
            }
        }

        public void AddForce()
        {
            if (player.IsJumping)
            {
                if (deltaY <= maxY && !CollidePlatform(player) && !CollideFrame(Bounds.Top, player)
                    && !player.IsDashing)
                {
                    player.Y -= forceY;
                    deltaY += forceY;
                }
                else
                {
                    player.IsJumping = false;
                    deltaY = 0;
                }
            }
        }

        public void Dash()
        {
            if (player.CanDash && player.IsDashing)
            {
                if (player.IsFalling && deltaX <= maxX &&
                    !CollideFrame(Bounds.Left, player) && 
                    !CollideFrame(Bounds.Right, player)
                    && !CollidePlatform(player))
                {
                    player.X += player.Direction * forceX;
                    deltaX += player.Speed;
                }
                else
                {
                    player.IsDashing = false;
                    deltaX = 0;
                }
            }
        }

        public void ShootFireball()
        {
            if (player.CanShoot)
            {
                fireballController.Generate(new Fireball(player.X + (player.Direction * 10), player.Y, player.Direction));
            }
        }

        public void MoveFireball()
        {
            foreach (Fireball fireball in fireballController.Fireballs)
            {
                if (!CollideFrame(Bounds.Left, fireball) &&
                    !CollideFrame(Bounds.Right, fireball) &&
                    !CollidePlatform(fireball) &&
                    !CollideSpike(fireball) &&
                    !CollideEntity(fireball))
                {
                    fireball.X += fireball.Direction * fireball.Speed;
                }
                else
                {
                    DamageEntity(fireball);
                    break;
                }
            }
        }

        public void EntityCollisionCheck()
        {
            if (CollideEntity(player))
            {
                SetOnSpawnPoint();
                Damage();
            }
        }
        #endregion

        #region Дополнительные методы
        public void Damage()
        {
            SetOnSpawnPoint();
            if (player.LivesAmount > 1)
            {
                player.LivesAmount--;
            }
            else if (!Level.IsLoadCustomLevel)
            {
                Level.CurrentLevel = 1;
                Level.TempLivesAmount = 0;
                Level.Attempts++;
                Level.IsGameOver = true;
            }
            else
            {
                Level.CurrentLevel = 4;
                Level.TempLivesAmount = 0;
                Level.IsGameOver = true;
            }
        }

        public void DamageEntity(Fireball fireball)
        {
            Entity entityExample;

            if (CollideEntity(fireball, out entityExample))
            {
                fireballController.Delete(fireball);
                if (entityExample.LivesAmount > 1)
                {
                    entityExample.LivesAmount--;
                }
                else
                {
                    entityController.Delete(entityExample);
                    player.ExpCount++;
                }
            }
            else
            {
                fireballController.Delete(fireball);
            }
        }

        public void CollectXP()
        {
            if (player.IsMovingLeft || player.IsMovingRight ||
                player.IsFalling || player.IsFalling)
            {
                if (CollideXPBlock())
                {
                    player.ExpCount++;
                }
            }
        }

        public void LevelExit()
        {
            if (LevelCompare() || Level.XPCount == 0)
            {
                if (CollideLevelEndBlock())
                {
                    if (Level.CurrentLevel < Level.LevelsCount)
                    {
                        Level.TempLivesAmount = player.LivesAmount;
                        Level.CurrentLevel++;
                    }
                    else if (!Level.IsLoadCustomLevel)
                    {
                        Level.CurrentLevel = 1;
                        Level.IsGameEnd = true;
                    }
                    else
                    {
                        Level.CurrentLevel = 4;
                        Level.IsGameEnd = true;
                    }
                }
            }
        }

        public bool IsAllExpCollected()
        {
            if (player.ExpCount == Level.XPCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LevelCompare()
        {
            if (player.ExpLevel > Level.CurrentLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void OnExpCountChanged()
        {
            if (IsAllExpCollected())
            {
                player.ExpLevel++;
                player.ExpCount = 0;
            }
        }

        public void OnPlayerDirectionChanged()
        {
            player.DefineTexture();
        }

        public void ActivateLevelBonus(byte levelIndex)
        {
            switch (levelIndex)
            {
                case 1:
                    player.CanDoubleJump = false;
                    player.CanDash = false;
                    player.CanShoot = false;
                    player.LivesAmount = 3;
                    break;
                case 2:
                    player.CanDoubleJump = true;
                    player.CanDash = false;
                    player.CanShoot = false;
                    break;
                case 3:
                    player.CanDoubleJump = true;
                    player.CanDash = true;
                    player.CanShoot = false;
                    player.LivesAmount++;
                    break;
                case 4:
                    player.CanDoubleJump = true;
                    player.CanDash = true;
                    player.CanShoot = true;
                    if (!Level.IsLoadCustomLevel)
                    {
                        player.LivesAmount++;
                    }
                    else
                    {
                        player.LivesAmount = 5;
                    }
                    break;
                default:
                    goto case 4;
            }
        }

        #endregion

        #region Коллизия
        public bool CollideFrame(Bounds bounds, Transform collider)
        {
            if (bounds == Bounds.Right)
            {
                if (collider.X + collider.Width + 8 >= frame.Width)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (bounds == Bounds.Left)
            {
                if (collider.X - 10 < frame.X)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (bounds == Bounds.Top)
            {
                if (collider.Y <= frame.Y + 8)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool CollideGround()
        {
            if (player.Y + player.Height + 3 >= ground.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool CollidePlatform(Transform collider)
        {
            bool colliding = false;

            if (platformController.Platforms.Count > 0)
            {
                foreach (Platform platform in platformController.Platforms)
                {
                    if (collider.X + collider.Width > platform.X &&
                         collider.X < platform.X + platform.Width &&
                         collider.Y + collider.Height > platform.Y &&
                         collider.Y < platform.Y + platform.Height)
                    {
                        colliding = true;
                    }
                }
            }

            return colliding;
        }

        public bool CollideLine()
        {
            bool colliding = false;

            if (platformController.Platforms.Count > 0)
            {
                foreach (Platform platform in platformController.Platforms)
                {
                    if (player.X + player.Width > platform.X &&
                        player.X <= platform.X + platform.Width &&
                        player.Y + player.Height <= platform.Y &&
                        player.Y >= platform.Y - player.Height - 3)
                    {
                        colliding = true;
                    }
                }
            }

            return colliding;
        }

        public bool CollideSpike(Transform collider)
        {
            bool colliding = false;

            if (spikeController.Spikes.Count > 0)
            {
                if (!player.IsDashing)
                {
                    foreach (Spike spike in spikeController.Spikes)
                    {
                        if (collider.X + collider.Width >= spike.X &&
                             collider.X <= spike.X + spike.Width &&
                             collider.Y + collider.Height >= spike.Y &&
                             collider.Y <= spike.Y + spike.Height)
                        {
                            colliding = true;
                        }
                    }
                }
            }

            return colliding;
        }

        public bool CollideEntity(Transform collider)
        {
            bool colliding = false;

            if (entityController.Entities.Count > 0)
            {
                foreach (Entity entity in entityController.Entities)
                {
                    if (!player.IsDashing)
                    {
                        if (collider.X + collider.Width >= entity.X + 2 &&
                        collider.X <= entity.X + entity.Width - 2 &&
                        collider.Y + collider.Height >= entity.Y + 3 &&
                        collider.Y <= entity.Y + entity.Height)
                        {
                            colliding = true;
                        }
                    }
                }
            }

            return colliding;
        }

        public bool CollideEntity(Transform collider, out Entity sender)
        {
            bool colliding = false;
            sender = null;

            if (entityController.Entities.Count > 0)
            {
                foreach (Entity entity in entityController.Entities)
                {
                    if (!player.IsDashing)
                    {
                        if (collider.X + collider.Width >= entity.X + 2 &&
                        collider.X <= entity.X + entity.Width - 2 &&
                        collider.Y + collider.Height >= entity.Y + 3 &&
                        collider.Y <= entity.Y + entity.Height)
                        {
                            colliding = true;
                            sender = entity;
                        }
                    }
                }
            }

            return colliding;
        }

        public bool CollideXPBlock()
        {
            bool colliding = false;

            if (xpBlockController.XPBlocks.Count > 0)
            {
                foreach (XPBlock xpBlock in xpBlockController.XPBlocks)
                {
                    if (player.X + player.Width >= xpBlock.X &&
                        player.X <= xpBlock.X + xpBlock.Width &&
                        player.Y + player.Height >= xpBlock.Y &&
                        player.Y <= xpBlock.Y + xpBlock.Height)
                    {
                        colliding = true;
                        xpBlockController.Delete(xpBlock);
                        break;
                    }
                }
            }

            return colliding;
        }

        public bool CollideLevelEndBlock()
        {
            if (player.X + player.Width >= levelEndBlock.X &&
            player.X <= levelEndBlock.X + levelEndBlock.Width &&
            player.Y + player.Height >= levelEndBlock.Y &&
            player.Y <= levelEndBlock.Y + levelEndBlock.Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}