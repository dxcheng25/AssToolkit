using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Collections;
using System.Windows.Forms;

namespace Srt2Ass
{
    public static class Configuration
    {
        static public Hashtable CfgProfiles = new Hashtable();

        public static void CreateMainCfgXML()
        {
            XmlDocument mainCfgXml = new XmlDocument();
            XmlElement mainCfgXmlElement_Root;
            XmlDeclaration mainCfgXmlDeclare = mainCfgXml.CreateXmlDeclaration("1.0", "UTF-8", "yes");
            mainCfgXmlElement_Root = mainCfgXml.CreateElement("StyleName_Path");
            mainCfgXml.AppendChild(mainCfgXmlElement_Root);
            mainCfgXml.Save(Application.StartupPath + "\\MainCfg.xml");
        }

        public static void LoadORCreateMainXML()
        {
            XmlDocument mainCfgXml = new XmlDocument();
            try
            {
                mainCfgXml.Load(Application.StartupPath + "\\MainCfg.xml");
                LoadMainCfgXML();
            }

            catch (Exception)
            {
                CreateMainCfgXML();
                LoadMainCfgXML();
            }
        }

        public static void LoadMainCfgXML()
        {
            CfgProfiles.Clear();
            XmlDocument mainCfgXml = new XmlDocument();
            mainCfgXml.Load(Application.StartupPath + "\\MainCfg.xml");

            XmlNodeList nodes = mainCfgXml.ChildNodes.Item(0).ChildNodes;
            foreach (XmlElement node in nodes)
            {
                CfgProfiles.Add(node.Attributes.Item(0).Value.ToString(), node.ChildNodes.Item(0).Attributes.Item(0).Value.ToString());
            }
        }

        public static void ModifyMainCfgXML(string name, string path, bool ExistsOrNot)
        {
            XmlDocument mainCfgXml = new XmlDocument();
            mainCfgXml.Load(Application.StartupPath + "\\MainCfg.xml");
            XmlNode rootNode = mainCfgXml.ChildNodes.Item(0);
            if (!ExistsOrNot)
            {
                XmlElement elem = mainCfgXml.CreateElement("Style");
                elem.SetAttribute("Name", name);
                rootNode.AppendChild(elem);
                XmlElement elem2 = mainCfgXml.CreateElement("Path");
                elem2.SetAttribute("Dtn", path);
                elem.AppendChild(elem2);
                CfgProfiles.Add(name, path);
            }

            mainCfgXml.Save(Application.StartupPath + "\\MainCfg.xml");
        }

        public static void CreateEffectProfile(string name, string[] scriptInfo, string[] V4Style, string events, string engEffect)
        {
            XmlDocument effProfile = new XmlDocument();

            effProfile.CreateXmlDeclaration("1.0", "UTF-8", "yes");
            XmlElement effProfileElement_root = effProfile.CreateElement("EffectProfile");
            effProfile.AppendChild(effProfileElement_root);
            XmlElement effProfileElement_ScriptInfo = effProfile.CreateElement("ScriptInfo");
            effProfileElement_root.AppendChild(effProfileElement_ScriptInfo);
            XmlElement effProfileElement_StringValue = effProfile.CreateElement("SIValues");
            foreach (string singleScriptInfo in scriptInfo)
            {
                effProfileElement_StringValue = effProfile.CreateElement("SIValues");
                effProfileElement_StringValue.SetAttribute("StringValue", singleScriptInfo);
                effProfileElement_ScriptInfo.AppendChild(effProfileElement_StringValue);
            }

            XmlElement effProfileElement_V4Style = effProfile.CreateElement("V4Style");
            effProfileElement_root.AppendChild(effProfileElement_V4Style);
            effProfileElement_StringValue = effProfile.CreateElement("VSValues");
            foreach (string singleV4Style in V4Style)
            {
                effProfileElement_StringValue = effProfile.CreateElement("VSValues");
                effProfileElement_StringValue.SetAttribute("StringValue", singleV4Style);
                effProfileElement_V4Style.AppendChild(effProfileElement_StringValue);
            }

            XmlElement effProfileElement_Events = effProfile.CreateElement("Events");
            effProfileElement_root.AppendChild(effProfileElement_Events);
            effProfileElement_StringValue = effProfile.CreateElement("EventValue");
            effProfileElement_StringValue.SetAttribute("StringValue", events);
            effProfileElement_Events.AppendChild(effProfileElement_StringValue);

            XmlElement effProfileElement_EngEffect = effProfile.CreateElement("EngEffect");
            effProfileElement_root.AppendChild(effProfileElement_EngEffect);
            effProfileElement_StringValue = effProfile.CreateElement("EngEffectValue");
            effProfileElement_StringValue.SetAttribute("StringValue", engEffect);
            effProfileElement_EngEffect.AppendChild(effProfileElement_StringValue);

            effProfile.Save(Application.StartupPath + "\\" + name + ".xml");

            if(CfgProfiles.ContainsKey(name))
            {
                ModifyMainCfgXML(name, Application.StartupPath + "\\" + name + ".xml", true);
            }

            else
            {
                ModifyMainCfgXML(name, Application.StartupPath + "\\" + name + ".xml", false);
            }
        }

        public static Hashtable LoadEffectProfile(string path)
        {
            Hashtable effects = new Hashtable();
            List<string> scriptInfo = new List<string>();
            List<string> V4Style = new List<string>();
            string events = "";
            string engEffect = "";

            XmlDocument effProfile = new XmlDocument();

            effProfile.Load(Application.StartupPath + "\\" + path);

            XmlNodeList effNodes = effProfile.ChildNodes.Item(0).ChildNodes;
            foreach (XmlNode effNode in effNodes)
            {
                foreach (XmlNode effValue in effNode.ChildNodes)
                {
                    if (effValue.Name == "SIValues")
                    {
                        scriptInfo.Add(effValue.Attributes.Item(0).Value);
                    }

                    if (effValue.Name == "VSValues")
                    {
                        V4Style.Add(effValue.Attributes.Item(0).Value);
                    }

                    if (effValue.Name == "EventValue")
                    {
                        events = effValue.Attributes.Item(0).Value;
                    }

                    if (effValue.Name == "EngEffectValue")
                    {
                        engEffect = effValue.Attributes.Item(0).Value;
                    }
                }
            }

            effects.Add("ScriptInfo", scriptInfo);
            effects.Add("V4Style", V4Style);
            effects.Add("Events", events);
            effects.Add("EngEffect", engEffect);

            return effects;
        }

        public static void DeleteProfile(string name)
        {
            XmlDocument mainCfgXml = new XmlDocument();
            mainCfgXml.Load(Application.StartupPath + "\\MainCfg.xml");
            XmlNodeList cfgNodes = mainCfgXml.ChildNodes.Item(0).ChildNodes;
            foreach (XmlElement elem in cfgNodes)
            {
                if (elem.Attributes.Item(0).Value == name)
                {
                    mainCfgXml.ChildNodes.Item(0).RemoveChild(elem);
                }
            }

            mainCfgXml.Save(Application.StartupPath + "\\MainCfg.xml");
            CfgProfiles.Remove(name);
        }
    }
}
