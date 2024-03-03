using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class Player : Transform
    {
        public delegate void ChangeDetect();
        public event ChangeDetect ExpCountChanged;
        public event ChangeDetect DirectionChanged;

        private byte expCount;
        private sbyte direction;

        public Image PlayerSprite { get; set; }
        public Image DashingPlayerSprite { get; set; }

        public int Speed { get; set; }
        public bool IsJumping { get; set; }
        public bool IsFalling { get; set; }
        public bool IsMovingLeft { get; set; }
        public bool IsMovingRight { get; set; }
        public byte ExpLevel { get; set; }
        public bool CanDoubleJump { get; set; }
        public byte LivesAmount { get; set; }
        public bool CanDash { get; set; }
        public bool IsDashing { get; set; }
        public bool CanShoot { get; set; }


        public byte ExpCount
        {
            get => expCount;
            set
            {
                if (expCount != value)
                {
                    expCount = value;
                    if (ExpCountChanged != null)
                    {
                        ExpCountChanged?.Invoke();
                    }
                }
            }
        }

        public sbyte Direction
        {
            get => direction;
            set
            {
                if (direction != value)
                {
                    direction = value;
                    if (DirectionChanged != null)
                    {
                        DirectionChanged?.Invoke();
                    }
                }
            }
        }

        public Player(int inputX, int inputY, int inputWidth, int inputHeight)
        {
            x = inputX;
            y = inputY;
            width = inputWidth;
            height = inputHeight;
            expCount = 0;

            Speed = 3;
            Direction = 1;
            IsJumping = false;
            IsFalling = false;
            IsMovingLeft = false;
            IsMovingRight = false;
            IsDashing = false;
            CanDoubleJump = false;
            CanDash = false;
            CanShoot = false;
            ExpLevel = Level.CurrentLevel;
            LivesAmount = 3;

            PlayerSprite = new Bitmap(TexturesResourceFile.playerSprite_1);
        }

        public void DefineTexture()
        {
            if (IsMovingLeft)
            {
                PlayerSprite = TexturesResourceFile.playerSprite_2;
            }
            else if (IsMovingRight)
            {
                PlayerSprite = TexturesResourceFile.playerSprite_1;
            }
        }
    }
}
