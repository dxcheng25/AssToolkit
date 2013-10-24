/************************************************************************
 *Copyright (C) 2013  David Cheng
 *Author:	David Cheng <david@dxcheng.me>
 ************************************************************************
 *
 *This program is free software; you can redistribute it and/or modify
 *it under the terms of the GNU General Public License as published by
 *the Free Software Foundation; either version 2 of the License, or
 *(at your option) any later version.
 *
 *This program is distributed in the hope that it will be useful,
 *but WITHOUT ANY WARRANTY; without even the implied warranty of
 *MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *GNU General Public License for more details.
 *
 *You should have received a copy of the GNU General Public License along
 *with this program; if not, write to the Free Software Foundation, Inc.,
 *51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
 ************************************************************************/

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
