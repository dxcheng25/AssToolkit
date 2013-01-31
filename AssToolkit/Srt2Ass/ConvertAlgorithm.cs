using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Srt2Ass
{
    class ConvertAlgorithm
    {
        List<string> originalSubs = new List<string>();
        Queue<string> qChiSub = new Queue<string>();
        Queue<string> qEngSub = new Queue<string>();
        Queue<string> qTimeSpan = new Queue<string>();
        Queue<string> qSubs = new Queue<string>();
        string fileSource;
        string folderDtn;
        string[] scriptInfo;
        string[] V4Style;
        string engStyle;
        string events;

        public void Entry(string fileSourceParam, string folderDtnParam, string[] scriptInfoParam, string[] V4StyleParam, string engStyleParam, string eventsParam)
        {
            originalSubs.Clear();
            qSubs.Clear();
            qChiSub.Clear();
            qEngSub.Clear();
            qTimeSpan.Clear();

            fileSource = fileSourceParam;
            folderDtn = folderDtnParam;
            scriptInfo = scriptInfoParam;
            V4Style = V4StyleParam;
            engStyle = engStyleParam;
            events = eventsParam;

            string fileDtn = null;
            WriteToFile WTF;

            fileDtn = folderDtn + "\\" + Path.GetFileName(fileSource);
            ReadFile(fileSource);

            WTF = new WriteToFile(fileDtn);
            WTF.WriteASS(scriptInfo, V4Style, events, qSubs, "Unicode");
            WTF.CloseFile();
            string fileName;
            fileName = fileDtn.Substring(0, fileDtn.LastIndexOf('.'));
            CopyTmpFileToAss(fileName);
        }

        private void CopyTmpFileToAss(string fileName)
        {
            CopyTmpFileToAss(fileName, fileName);
        }

        private void CopyTmpFileToAss(string originalFileName, string fileName)
        {
            try
            {
                File.Copy(originalFileName + ".tmp", fileName + ".ass", false);
            }

            catch (Exception)
            {
                fileName += "_new";
                CopyTmpFileToAss(originalFileName, fileName);
            }

            File.Delete(originalFileName + ".tmp");
        }

        private void ReadFile(string fileSource)
        {
            string strTimeSpan = "";
            int startIndex = 0;
            int endIndex = 0;
            StreamReader readSrc;

            try
            {
                //Regex exEngOrChi = new Regex(@"[^\x00-\xff]");
                Regex exIsTime = new Regex(@"(.+)(?=-)-->(?<=>)[\s][^\s]+");
                //if (strEncoding == "ANSI")
                //{
                    readSrc = new StreamReader(fileSource, Encoding.GetEncoding(936));
                //}
                //else
                //{
                //    readSrc = new StreamReader(fileSource, Encoding.Unicode);
                //}

                while (!readSrc.EndOfStream)
                {
                    originalSubs.Add(readSrc.ReadLine());
                }

                for (int i = 0; i < originalSubs.Count; i++)
                {
                    if (exIsTime.IsMatch(originalSubs[i]))
                    {
                        if (startIndex == 0)
                        {
                            startIndex = i;
                            continue;
                        }

                        else
                        {
                            strTimeSpan = originalSubs[startIndex];
                            endIndex = i;
                            EnqueueSubs(ref startIndex, ref endIndex, ref strTimeSpan, originalSubs);
                        }
                    }
                }

                endIndex = originalSubs.Count + 1;
                strTimeSpan = originalSubs[startIndex];
                EnqueueSubs(ref startIndex, ref endIndex, ref strTimeSpan, originalSubs);
                readSrc.Close();
                #region deprecated
                /*
                        //排除文件头部空行
                        strTmp = readSrc.ReadLine();
                        if (exIsTime.IsMatch(strTmp))
                        {
                            while (!readSrc.EndOfStream)
                            {
                                strTmp = readSrc.ReadLine();
                                if (strTmp == "")
                                {

                                }

                                else if (exEngOrChi.IsMatch(strTmp))
                                {
                                    if (strChiSub != "")
                                        strChiSub = strChiSub + "\\N" + strTmp;
                                    else
                                        strChiSub = strTmp;
                                }

                                else
                                {
                                    if (strEngSub != "")
                                        strEngSub = strEngSub + "\\N" + strTmp;
                                    else
                                        strEngSub = strTmp;
                                }
                            }
                        }
                        while (strTmp == "" && !readSrc.EndOfStream)
                        {
                            strTmp = readSrc.ReadLine();
                        }

                        strNo = strTmp;
                        if (!exIsNumber.IsMatch(strNo))
                        {
                            throw new NotTheFileException("文件错误，请重新选择");
                        }

                        if (!readSrc.EndOfStream)
                        {
                            strTimeSpan = readSrc.ReadLine();
                        }
                        //strChiSub = readSrc.ReadLine();
                        while (!readSrc.EndOfStream)
                        {
                            strTmp = readSrc.ReadLine();
                            if (strTmp == "")
                                break;

                            else if (exEngOrChi.IsMatch(strTmp))
                            {
                                if (strChiSub != "")
                                    strChiSub = strChiSub + "\\N" + strTmp;
                                else
                                    strChiSub = strTmp;
                            }

                            else
                            {
                                if (strEngSub != "")
                                    strEngSub = strEngSub + "\\N" + strTmp;
                                else
                                    strEngSub = strTmp;
                            }
                        }

                        TimeProc(strTimeSpan, ref startTime, ref endTime);

                        if (strEngSub == "")
                        {
                            sub = "Dialogue: 0," + startTime + "," + endTime + ",*Default,NTP,0000,0000,0000,," + strChiSub;
                        }

                        else
                        {
                            sub = "Dialogue: 0," + startTime + "," + endTime + ",*Default,NTP,0000,0000,0000,," + strChiSub + "\\N" + engStyle + strEngSub;
                        }

                        qSubs.Enqueue(sub);
                        strChiSub = strEngSub = strTimeSpan = "";
                    }
                 */
                #endregion
            }

            catch (Exception)
            {
                throw new Exception("字幕转换失败，错误时间：" + strTimeSpan);
            }
        }

        public void EnqueueSubs(ref int startIndex, ref int endIndex, ref string strTimeSpan, List<string> originalSubs)
        {
            string strTmp = "";
            string sub = "";
            string strChiSub = "";
            string strEngSub = "";
            string startTime = "";
            string endTime = "";
            int subCount = 0;
            Regex exEngOrChi = new Regex(@"[\u4e00-\u9fa5]");

            for (int k = startIndex + 1; k < endIndex - 1; k++)
            {
                strTmp = originalSubs[k];
                if (strTmp == "")
                {

                }

                else
                {
                    subCount++;
                    if (exEngOrChi.IsMatch(strTmp) || subCount == 1)
                    {
                        if (strChiSub != "")
                            strChiSub = strChiSub + "\\N" + strTmp;
                        else
                            strChiSub = strTmp;
                    }

                    else
                    {
                        if (strEngSub != "")
                            strEngSub = strEngSub + "\\N" + strTmp;
                        else
                            strEngSub = strTmp;
                    }
                }
            }

            TimeProc(strTimeSpan, ref startTime, ref endTime);

            if (strEngSub == "")
            {
                sub = "Dialogue: 0," + startTime + "," + endTime + ",*Default,NTP,0000,0000,0000,," + strChiSub;
            }

            else if (strChiSub == "")
            {
                sub = "Dialogue: 0," + startTime + "," + endTime + ",*Default,NTP,0000,0000,0000,," + engStyle + strEngSub;
            }

            else
            {
                sub = "Dialogue: 0," + startTime + "," + endTime + ",*Default,NTP,0000,0000,0000,," + strChiSub + "\\N" + engStyle + strEngSub;
            }

            qSubs.Enqueue(sub);
            strChiSub = strEngSub = strTimeSpan = "";
            startIndex = endIndex;
            subCount = 0;
        }

        public void TimeProc(string timeSpan, ref string startTime, ref string endTime)
        {
            Regex exTime = new Regex(@"\d{1}\:\d{2}\:\d{2}\,\d{2}");
            MatchCollection mtTimes = exTime.Matches(timeSpan);
            startTime = mtTimes[0].ToString();
            endTime = mtTimes[1].ToString();
            startTime = startTime.Replace(',', '.');
            endTime = endTime.Replace(',', '.');
        }
    }
}
