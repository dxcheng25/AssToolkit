using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;
using Ass2Srt;
using Srt2Ass;

namespace AssToolkit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            MaximizeBox = false;
            //Ass2Srt
            lvASSFileSelection.Clear();
            rbChinEng.Checked = true;

            //Srt2Ass
            lvSrtFileSelection.Clear();
            LoadEffects();
        }

        #region Ass2Srt
        private void btnA2SStartProcessing_Click(object sender, EventArgs e)
        {
            bgwA2SOutput.RunWorkerAsync();
        }

        private void bgwA2SOutput_DoWork(object sender, DoWorkEventArgs e)
        {
            A2SControlEnabled(false);

            string strDialogues;
            string strDescriptions;
            string strFolderPath;
            string strFileNameWithExtension;
            string strFileNameWithoutExtension;
            string strFilePath;
            string strDestDir = null;
            int fileNum = lvASSFileSelection.Items.Count;
            ssProgressBar.Maximum = fileNum;
            ssProgressBar.Minimum = 0;
            ssProgressBar.Step = 1;
            ssProgressBar.Value = 0;

            foreach (ListViewItem lviFile in lvASSFileSelection.Items)
            {
                strDestDir = tbSrtOutputFolder.Text;
                strFilePath = (string)lviFile.Tag;
                int lastSlash = strFilePath.LastIndexOf("\\");
                strFolderPath = strFilePath.Substring(0, lastSlash);
                strFileNameWithExtension = strFilePath.Substring(lastSlash + 1);

                int lastDot = strFileNameWithExtension.LastIndexOf(".");
                strFileNameWithoutExtension = strFileNameWithExtension.Substring(0, lastDot);

                AssReader ar = new AssReader(strFilePath);
                if (ar.IsValid())
                {
                    foreach (ListViewItem lviType in lvVersionSelection.CheckedItems)
                    {
                        if (lviType.Index <= 4)
                        {
                            strDialogues = ar.ReadDialogues();
                            AssAnalyzerForSrt aafs = new AssAnalyzerForSrt(strDialogues, lviType.Index, rbChinEng.Checked);
                            string[] strSrtLines = aafs.Analyze();
                            SrtWriter sw = new SrtWriter(strDestDir, strFileNameWithoutExtension, lviType.Index);
                            sw.WriteSrtFile(strSrtLines);
                        }

                        else
                        {
                            string[] strAssDialogues;
                            string[] strAssDescriptions;
                            strDialogues = ar.ReadDialogues();
                            strDescriptions = ar.ReadDescription();
                            AssAnalyzerForAss aafa = new AssAnalyzerForAss(strDialogues, strDescriptions, lviType.Index, rbChinEng.Checked);
                            aafa.Analyze(out strAssDescriptions, out strAssDialogues);
                            AssWriter aw = new AssWriter(strDestDir, strFileNameWithoutExtension, lviType.Index);
                            aw.WriteAssFile(strAssDescriptions, strAssDialogues);
                        }
                    }

                    ZipPatcher(strDestDir, strFileNameWithoutExtension);
                    ssProgressBar.PerformStep();
                }

                else
                {
                    MessageBox.Show("不是.ass文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            A2SControlEnabled(true);
        }

        private void A2SControlEnabled(bool enabled)
        {
            gbSrtOutputFolder.Enabled = enabled;
            gbVersions.Enabled = enabled;
            gbAssFile.Enabled = enabled;
            btnA2SStartProcessing.Enabled = enabled;
        }

        private void lvASSFileSelection_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }

            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lvASSFileSelection_DragDrop(object sender, DragEventArgs e)
        {
            lvASSFileSelection.Clear();
            Array arrFilePaths;
            arrFilePaths = ((Array)e.Data.GetData(DataFormats.FileDrop));

            for (int i = 0; i < arrFilePaths.Length; i++)
            {
                string filePath = arrFilePaths.GetValue(i).ToString();
                int lastDot = filePath.LastIndexOf(".");
                string fileExtension = filePath.Substring(lastDot);
                int lastSlash = filePath.LastIndexOf("\\");
                string fileNameWithExtension = filePath.Substring(lastSlash + 1);
                if (fileExtension == ".ass")
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.StateImageIndex = 0;
                    lvi.Text = fileNameWithExtension;
                    lvi.Tag = filePath;
                    lvASSFileSelection.Items.Add(lvi);
                }
            }

            if (lvASSFileSelection.Items.Count != 0)
            {
                string filePath = (string)lvASSFileSelection.Items[0].Tag;
                tbSrtOutputFolder.Text = filePath.Substring(0, filePath.LastIndexOf("\\"));
            }
        }

        private void ZipPatcher(string folderName, string fileName)
        {
            string szPath = Application.StartupPath + "\\7z\\" + "7za.exe";
            string arguements = "a \"" + folderName + "\\" + fileName + ".zip\" \"" + folderName + "\\" + fileName + "\"";

            Process szProcess = new Process();
            szProcess.StartInfo.FileName = szPath;
            szProcess.StartInfo.Arguments = arguements;
            szProcess.StartInfo.UseShellExecute = false;
            szProcess.StartInfo.CreateNoWindow = true;
            szProcess.StartInfo.RedirectStandardOutput = true;
            
            szProcess.Start();
            szProcess.BeginOutputReadLine();
            szProcess.OutputDataReceived += new DataReceivedEventHandler(SZProcess_OutputDataReceived);

        }

        private void SZProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if(!string.IsNullOrEmpty(e.Data))
            {
                Console.WriteLine(e.Data + Environment.NewLine);
            }
        }

        private void btnSrtFdSelection_Click(object sender, EventArgs e)
        {
            fbdSelectDestDir.ShowDialog();
            tbSrtOutputFolder.Text = fbdSelectDestDir.SelectedPath;
        }

        private void rbChinEng_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChinEng.Checked == true)
            {
                for (int i = 0; i < lvVersionSelection.Items.Count; i++)
                {
                    lvVersionSelection.Items[i].Checked = false;
                }

                for (int i = 0; i < lvVersionSelection.Items.Count; i++)
                {
                    lvVersionSelection.Items[i].Checked = true;
                }
            }
        }

        private void rbChi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChi.Checked == true)
            {
                for (int i = 0; i < lvVersionSelection.Items.Count; i++)
                {
                    lvVersionSelection.Items[i].Checked = false;
                }

                lvVersionSelection.Items[2].Checked = true;
                lvVersionSelection.Items[3].Checked = true;
                lvVersionSelection.Items[7].Checked = true;
                lvVersionSelection.Items[8].Checked = true;
            }
        }
        #endregion

        #region Srt2Ass
        private void lvSrtFileSelection_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }

            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lvSrtFileSelection_DragDrop(object sender, DragEventArgs e)
        {
            lvSrtFileSelection.Clear();
            Array arrFilePaths;
            arrFilePaths = ((Array)e.Data.GetData(DataFormats.FileDrop));

            for (int i = 0; i < arrFilePaths.Length; i++)
            {
                string filePath = arrFilePaths.GetValue(i).ToString();
                int lastDot = filePath.LastIndexOf(".");
                string fileExtension = filePath.Substring(lastDot);
                int lastSlash = filePath.LastIndexOf("\\");
                string fileNameWithExtension = filePath.Substring(lastSlash + 1);
                if (fileExtension == ".srt")
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.StateImageIndex = 0;
                    lvi.Text = fileNameWithExtension;
                    lvi.Tag = filePath;
                    lvSrtFileSelection.Items.Add(lvi);
                }
            }

            if (lvSrtFileSelection.Items.Count != 0)
            {
                string filePath = (string)lvSrtFileSelection.Items[0].Tag;
                tbASSOutputFolder.Text = filePath.Substring(0, filePath.LastIndexOf("\\"));
            }
        }

        private void btnASSFolderSelection_Click(object sender, EventArgs e)
        {
            fbdSelectDestDir.ShowDialog();
            tbASSOutputFolder.Text = fbdSelectDestDir.SelectedPath;
        }

        private void bgwS2AOutput_DoWork(object sender, DoWorkEventArgs e)
        {
            ConvertAlgorithm C = new ConvertAlgorithm();

            int fileNum = lvSrtFileSelection.Items.Count;
            string[] scriptInfo = new string[0];
            string[] v4Style = new string[0];
            string events = "";
            string engStyle = "";

            ssProgressBar.Maximum = fileNum;
            ssProgressBar.Minimum = 0;
            ssProgressBar.Step = 1;
            ssProgressBar.Value = 0;

            try
            {
                if (lvSrtFileSelection.Items.Count == 0)
                {
                    throw new Exception("请选择源文件");
                }

                if (tbASSOutputFolder.Text == "")
                {
                    throw new Exception("请选择目标文件夹");
                }

                if (cbEffCfg.Text == "")
                {
                    throw new Exception("请选择特效");
                }

                ReadEffectDetail(cbEffCfg.Text, ref scriptInfo, ref v4Style, ref events, ref engStyle);
                S2AControlEnable(false);
                foreach (ListViewItem lviFile in lvSrtFileSelection.Items)
                {
                    string file = lviFile.Tag as string;
                    C.Entry(file, tbASSOutputFolder.Text, scriptInfo, v4Style, engStyle, events);
                    ssProgressBar.PerformStep();
                }
                S2AControlEnable(true);

            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadEffectDetail(string name, ref string[] scriptInfo, ref string[] v4Style,
                                      ref string events, ref string engStyle)
        {
            Hashtable htEffects;
            List<string> lScriptInfo;
            List<string> lV4Style;
            string strEvents;
            string strEngEffect;

            if (Configuration.CfgProfiles.ContainsKey(name))
            {
                htEffects = Configuration.LoadEffectProfile(name + ".xml");
                lScriptInfo = (List<string>)htEffects["ScriptInfo"];
                lV4Style = (List<string>)htEffects["V4Style"];
                strEvents = (string)htEffects["Events"];
                strEngEffect = (string)htEffects["EngEffect"];

                scriptInfo = lScriptInfo.ToArray();
                v4Style = lV4Style.ToArray();
                events = strEvents;
                engStyle = strEngEffect;
            }

            else
            {
                scriptInfo = new string[0];
                v4Style = new string[0];
                events = "";
                engStyle = "";
            }
        }        
        
        private void btnS2AStartProcessing_Click(object sender, EventArgs e)
        {
            bgwS2AOutput.RunWorkerAsync();
        }

        private void btnAddEff_Click(object sender, EventArgs e)
        {
            AddNewEff ade = new AddNewEff();
            ade.ShowDialog(this);
            LoadEffects();
        }

        private void LoadEffects()
        {
            cbEffCfg.Items.Clear();
            cbEffCfg.Text = "";
            Configuration.LoadORCreateMainXML();
            if (Configuration.CfgProfiles.Count != 0)
            {
                foreach (DictionaryEntry de in Configuration.CfgProfiles)
                {
                    cbEffCfg.Items.Add(de.Key.ToString());
                }
            }
        }        
        
        private void btnModifyEff_Click(object sender, EventArgs e)
        {
            string effName = cbEffCfg.Text;
            string[] scriptInfo = new string[0];
            string[] v4Style = new string[0];
            string engStyle = "";
            string events = "";

            ReadEffectDetail(effName, ref scriptInfo, ref v4Style, ref events, ref engStyle);
            AddNewEff ade = new AddNewEff(effName, scriptInfo, v4Style, events, engStyle);
            ade.ShowDialog(this);
            LoadEffects();
        }       
        
        private void btnImportEffFiles_Click(object sender, EventArgs e)
        {
            string name;
            string path;
            string[] strFileSources = null;
            ofdSelectFile.Multiselect = true;
            ofdSelectFile.FileName = null;
            ofdSelectFile.Filter = "XML配置文件(*.xml)|*.xml";
            ofdSelectFile.ShowDialog();
            strFileSources = ofdSelectFile.FileNames;

            foreach (string fileSource in strFileSources)
            {
                try
                {
                    path = fileSource.Substring(((fileSource.LastIndexOf("\\")) + 1), fileSource.Length - fileSource.LastIndexOf("\\") - 1);
                    name = path.Substring(0, path.LastIndexOf('.'));
                    File.Copy(fileSource, Application.StartupPath + "\\" + path);
                    Configuration.ModifyMainCfgXML(name, path, false);
                    LoadEffects();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelEff_Click(object sender, EventArgs e)
        {
            string name = cbEffCfg.Text;
            Configuration.DeleteProfile(name);
            try
            {
                File.Delete(name + ".xml");
            }

            catch (Exception)
            {

            }

            LoadEffects();
        }

        private void S2AControlEnable(bool isEnable)
        {
            gbEffCfg.Enabled = isEnable;
            gbSrtFile.Enabled = isEnable;
            gbSrtOutputFolder.Enabled = isEnable;
        }

        #endregion
    }
}
