using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManager
{
    class FileIO
    {
        string curDir;
        string path;
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
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                List<string> content = new List<string>();

                content.Add(file.Name.Split('.')[0]);
                while (!sr.EndOfStream)
                {
                    content.Add(sr.ReadLine());
                }

                sr.Close();
                fileContent.Add(content);
            }

            return fileContent;
        }

        public bool SaveFile(RecipeData data)
        {
            string path = curDir + @"\recipe\" + data.name + ".csv";

            FileStream fs;
            StreamWriter sw;
            try
            {
                fs = new FileStream(path, FileMode.Create);
                sw = new StreamWriter(fs, Encoding.Default);

                sw.WriteLine(data.category);
                sw.WriteLine(data.level);
                sw.WriteLine(data.time);

                string foods = "";
                foreach(string item in data.mainFood)
                {
                    foods += item + ",";
                }
                sw.WriteLine(foods);

                string sub = "\"";
                foreach(string item in data.subFood)
                {
                    sub += item + ",";
                }
                sub += "\"";
                sw.WriteLine(sub);

                foreach(string item in data.content)
                {
                    sw.WriteLine(item);
                }

                sw.Close();
                fs.Close();

                MessageBox.Show("저장 했습니다.");
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("저장에 실패했습니다.");
                return true;
            }
        }
    }
}
