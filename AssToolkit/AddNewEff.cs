using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Srt2Ass;

namespace AssToolkit
{
    public partial class AddNewEff : Form
    {
        public bool IsModification = false;

        public AddNewEff()
        {
            InitializeComponent();
            IsModification = false;
        }

        public AddNewEff(string name, string[] scriptInfo, string[] v4Style, string events, string engStyle)
        {
            InitializeComponent();
            IsModification = true;
            tbVS.Lines = v4Style;
            tbSI.Lines = scriptInfo;
            tbEng.Text = engStyle;
            tbEvents.Text = events;
            tbEffName.Text = name;
        }

        private void btnSaveEffect_Click(object sender, EventArgs e)
        {
            string[] strScriptInfo = tbSI.Lines;
            string[] strV4Style = tbVS.Lines;
            string events = tbEvents.Text;
            string engEffect = tbEng.Text;
            string name = tbEffName.Text;
            try
            {
                if (tbEvents.Text == "" || tbSI.Text == "" || tbVS.Text == "")
                {
                    throw new Exception("请补全特效代码");
                }

                if (IsModification)
                {
                    Configuration.CreateEffectProfile(name, strScriptInfo, strV4Style, events, engEffect);
                    MessageBox.Show("特效已经修改", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    if (!Configuration.CfgProfiles.ContainsKey(name))
                    {
                        Configuration.CreateEffectProfile(name, strScriptInfo, strV4Style, events, engEffect);
                        MessageBox.Show("新特效已添加", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        throw new Exception("特效名重复  请更换");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
