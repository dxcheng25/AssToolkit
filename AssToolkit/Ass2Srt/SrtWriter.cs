using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Ass2Srt
{
    class SrtWriter
    {
        string strFileName;
        string strFolderPath;
        string strNewFolderPath;
        int type;
        FileStream fs;
        StreamWriter sw;

        public SrtWriter(string strFolderPath, string strFileNameWithoutExtension, int type)
        {
            this.strFolderPath = strFolderPath;
            this.strFileName = strFileNameWithoutExtension;
            this.type = type;
        }

        public bool WriteSrtFile(string[] strSrtLines)
        {
            CreateFolder();
            switch (type)
            {
                case 0:
                    strFileName += ".简体&英文";
                    break;
                case 1:
                    strFileName += ".繁体&英文";
                    break;
                case 2:
                    strFileName += ".简体";
                    break;
                case 3:
                    strFileName += ".繁体";
                    break;
                case 4:
                    strFileName += ".英文";
                    break;
            }

            strFileName += ".srt";

            try
            {
                fs = new FileStream(strNewFolderPath + "\\" + strFileName, FileMode.OpenOrCreate);
                //if (type == 0 || type == 2)
                //{
                //    sw = new StreamWriter(fs, Encoding.GetEncoding(936));
                //}
                //else if (type == 1 || type == 3)
                //{
                //    sw = new StreamWriter(fs, Encoding.GetEncoding(950));
                //}
                //else
                //{
                    sw = new StreamWriter(fs, Encoding.Unicode);
                //}

                foreach (string s in strSrtLines)
                {
                    sw.WriteLine(s);
                    sw.Flush();
                }

                fs.Close();
                return true;
            }

            catch(Exception)
            {
                return false;
            }
        }

        private void CreateFolder()
        {
            string strDirectoryName = strFolderPath + "\\" + strFileName;
            if (Directory.Exists(strDirectoryName))
            {

            }

            else
            {
                Directory.CreateDirectory(strDirectoryName);
            }

            strNewFolderPath = strDirectoryName;
        }
    }
}
