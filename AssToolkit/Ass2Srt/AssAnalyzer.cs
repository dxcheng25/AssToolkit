using System;
using System.Collections.Generic;
using System.Text;

namespace Ass2Srt
{
    class AssAnalyzer
    {
        protected string ConvertToTrad(string strDialogue)
        {
            //return (Microsoft.VisualBasic.Strings.StrConv(strDialogue as String, Microsoft.VisualBasic.VbStrConv.TraditionalChinese, 0));
			return "";
		}

        protected string[] SplitString(string originalString, string seperator)
        {
            List<string> lSS = new List<string>();
            while (true)
            {
                int index = originalString.IndexOf(seperator);
                if (index >= 0)
                {
                    lSS.Add(originalString.Substring(0, index));
                    originalString = originalString.Substring(index + 2);
                }

                else
                {
                    lSS.Add(originalString);
                    break;
                }
            }

            return lSS.ToArray();
        }

        protected string[] DialogueSplitter(string strDialogues)
        {
            string[] strSplittedDialogues = SplitString(strDialogues, "\r\n");

            return strSplittedDialogues;
        }
    }
}
