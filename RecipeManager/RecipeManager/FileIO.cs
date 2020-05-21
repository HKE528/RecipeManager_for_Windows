using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    class FileIO
    {
        string curDir;
        DirectoryInfo dir;
        FileInfo[] files;
        List<List<string>> fileContent;

        //파일 읽기
        public FileIO()
        {
            curDir = Environment.CurrentDirectory;
            string path = curDir + @"\recipe";
            dir = new DirectoryInfo(path);
            if(!dir.Exists)
            {
                dir.Create();
            }

            files = dir.GetFiles();
        }
    
        private void GetFileList()
        {
            List<FileInfo> fileList = new List<FileInfo>();
            foreach(var file in files)
            {
                fileList.Add(file);
            }
        }

        public List<List<string>> GetFileContent()
        {
            if (files.Length == 0)
                return null;

            fileContent = new List<List<string>>();
            FileStream fs;

            foreach(var file in files)
            {
                fs = file.OpenRead();
                StreamReader sr = new StreamReader(fs);
                List<string> content = new List<string>();

                content.Add(file.Name);
                while (!sr.EndOfStream)
                {
                    content.Add(sr.ReadLine());
                }

                sr.Close();
                fileContent.Add(content);
            }

            return fileContent;
        }
    }
}
