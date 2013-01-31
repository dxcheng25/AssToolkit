using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Ass2Srt
{
    class AssReader
    {
        string filePath;
        string fileContent;
        FileStream fs;
        StreamReader sr;

        public AssReader(string filePath)
        {
            this.filePath = filePath;
        }

        public bool IsValid()
        {
            try
            {
                fs = new FileStream(filePath, FileMode.Open);
                sr = new StreamReader(fs, true);

                if (fs.Length > 1024 * 1024 || fs.Length <= 0)    //文件不得大于1M
                {
                    return false;
                }

                else
                {
                    fileContent = sr.ReadToEnd();

                    if (fileContent.Contains("Dialogue:"))
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            catch (Exception)
            {
                return false;
            }

            finally
            {
                fs.Close();
            }
        }

        public string ReadDialogues()
        {
            string strDialogues;
            int firstDialoguePos = fileContent.IndexOf("Dialogue");
            strDialogues = fileContent.Substring(firstDialoguePos);

            return strDialogues;
        }

        public string ReadDescription()
        {
            string strDescription;
            int firstDialoguePos = fileContent.IndexOf("Dialogue");
            strDescription = fileContent.Substring(0, firstDialoguePos);

            return strDescription;
        }
    }
}
