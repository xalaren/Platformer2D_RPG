using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Platformer_2D_RPG.Editor
{
    class Files
    {
        public string ParentDirectoryPath { get; private set; }  //Родительский каталог
        public string DirectoryPath { get; private set; }  //Каталог, задаваемый пользователем

        public Files()
        {
            ParentDirectoryPath = @"C:\Platformer2D\Files";
            DirectoryCreateOrOpen();
        }

        private void DirectoryCreateOrOpen()
        {
            if (!Directory.Exists(ParentDirectoryPath))
            {
                Directory.CreateDirectory(ParentDirectoryPath);
            }
            DirectoryPath = ParentDirectoryPath;
        }

        public void DirectoryCreateOrOpen(string name)
        {
            DirectoryPath = ParentDirectoryPath + @"\" + name;
            if (!Directory.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
            }
        }

        public void ToCatalog(string catalogName)
        {
            if (catalogName != @"\")
            {
                DirectoryCreateOrOpen(catalogName);
            }
            else
            {
                DirectoryCreateOrOpen();
            }
        }

        public void SaveItemsLine(string name, string item)
        {
            string curPath = DirectoryPath + $@"\{name}.dat";
            using (StreamWriter sw = new StreamWriter(curPath, true, Encoding.UTF8))
            {
                sw.WriteLine(item);
            }
        }

        public void SaveItems(string name, string item)
        {
            string curPath = DirectoryPath + $@"\{name}.dat";
            using (StreamWriter sw = new StreamWriter(curPath, true, Encoding.UTF8))
            {
                sw.WriteLine(item);
            }
        }
        public List<string> LoadItems(string name)
        {
            string curPath = DirectoryPath + $@"\{name}.dat";
            List<string> lines = new List<string>();
            if (File.Exists(curPath))
            {
                using (StreamReader sr = new StreamReader(curPath, Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        lines.Add(sr.ReadLine());
                    }
                }
            }
            return lines;
        }

        public bool EmptyFileCheck(string name)
        {
            string curPath = DirectoryPath + $@"\{name}.dat";
            string text = "";
            if (File.Exists(curPath))
            {
                using (StreamReader sr = new StreamReader(curPath, Encoding.UTF8))
                {
                    sr.ReadToEnd();
                }
            }

            return String.IsNullOrWhiteSpace(text);
        }

        public void DeleteFile(string name)
        {
            string curPath = DirectoryPath + $@"\{name}.dat";
            if (File.Exists(curPath))
            {
                File.Delete(curPath);
            }
        }

        public void DeleteDirectory(string name)
        {
            ToCatalog(name);
            if (Directory.Exists(DirectoryPath))
            {
                Directory.Delete(DirectoryPath, true);
            }
        }
    }
}
