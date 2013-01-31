using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Srt2Ass
{
    class WriteToFile
    {
        FileStream FS;
        StreamWriter writeTmpUnicode;
 

        public WriteToFile(string fileDtn)
        {
            string fileName;
            fileName = fileDtn.Substring(0, fileDtn.LastIndexOf('.'));
            FS = new FileStream(fileName + ".tmp", FileMode.Append);
            writeTmpUnicode = new StreamWriter(FS, Encoding.Unicode);
        }

        public void WriteASS(string[] ScriptInfo, string[]V4Style, string events, Queue<string> qSubs, string encodeType)
        {
            writeTmpUnicode.WriteLine("[Script Info]");
            foreach (string strScriptInfo in ScriptInfo)
            {
                writeTmpUnicode.WriteLine(strScriptInfo);
            }
            writeTmpUnicode.WriteLine("");
            writeTmpUnicode.WriteLine("[V4+ Styles]");
            foreach (string strV4Style in V4Style)
            {
                writeTmpUnicode.WriteLine(strV4Style);
            }
            writeTmpUnicode.WriteLine("");
            writeTmpUnicode.WriteLine("[Events]");
            writeTmpUnicode.WriteLine(events);

            while (qSubs.Count != 0)
            {
                writeTmpUnicode.WriteLine(qSubs.Dequeue());
            }

            writeTmpUnicode.Flush();
        }

        public void CloseFile()
        {
            FS.Close();
        }
    }
}
