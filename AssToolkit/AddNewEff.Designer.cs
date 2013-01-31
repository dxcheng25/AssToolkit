namespace AssToolkit
{
    partial class AddNewEff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewEff));
            this.tbEvents = new System.Windows.Forms.TextBox();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.lbEvents = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVS = new System.Windows.Forms.TextBox();
            this.lbVS = new System.Windows.Forms.Label();
            this.tbSI = new System.Windows.Forms.TextBox();
            this.lbSI = new System.Windows.Forms.Label();
            this.gbEffDetail = new System.Windows.Forms.GroupBox();
            this.btnSaveEffect = new System.Windows.Forms.Button();
            this.lbEffName = new System.Windows.Forms.Label();
            this.tbEffName = new System.Windows.Forms.TextBox();
            this.gbEffDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEvents
            // 
            this.tbEvents.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEvents.Location = new System.Drawing.Point(6, 262);
            this.tbEvents.Name = "tbEvents";
            this.tbEvents.Size = new System.Drawing.Size(428, 21);
            this.tbEvents.TabIndex = 23;
            this.tbEvents.Text = "Format: Layer, Start, End, Style, Actor, MarginL, MarginR, MarginV, Effect, Text";
            // 
            // tbEng
            // 
            this.tbEng.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEng.Location = new System.Drawing.Point(6, 308);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(428, 21);
            this.tbEng.TabIndex = 24;
            // 
            // lbEvents
            // 
            this.lbEvents.AutoSize = true;
            this.lbEvents.Location = new System.Drawing.Point(4, 247);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(41, 12);
            this.lbEvents.TabIndex = 21;
            this.lbEvents.Text = "Events";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "英文行特效";
            // 
            // tbVS
            // 
            this.tbVS.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbVS.Location = new System.Drawing.Point(6, 144);
            this.tbVS.Multiline = true;
            this.tbVS.Name = "tbVS";
            this.tbVS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbVS.Size = new System.Drawing.Size(428, 95);
            this.tbVS.TabIndex = 20;
            // 
            // lbVS
            // 
            this.lbVS.AutoSize = true;
            this.lbVS.Location = new System.Drawing.Point(4, 130);
            this.lbVS.Name = "lbVS";
            this.lbVS.Size = new System.Drawing.Size(59, 12);
            this.lbVS.TabIndex = 19;
            this.lbVS.Text = "V4+ Style";
            // 
            // tbSI
            // 
            this.tbSI.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSI.Location = new System.Drawing.Point(6, 33);
            this.tbSI.Multiline = true;
            this.tbSI.Name = "tbSI";
            this.tbSI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSI.Size = new System.Drawing.Size(428, 92);
            this.tbSI.TabIndex = 18;
            this.tbSI.Text = resources.GetString("tbSI.Text");
            // 
            // lbSI
            // 
            this.lbSI.AutoSize = true;
            this.lbSI.Location = new System.Drawing.Point(4, 18);
            this.lbSI.Name = "lbSI";
            this.lbSI.Size = new System.Drawing.Size(71, 12);
            this.lbSI.TabIndex = 17;
            this.lbSI.Text = "Script Info";
            // 
            // gbEffDetail
            // 
            this.gbEffDetail.Controls.Add(this.tbSI);
            this.gbEffDetail.Controls.Add(this.tbEvents);
            this.gbEffDetail.Controls.Add(this.lbSI);
            this.gbEffDetail.Controls.Add(this.tbEng);
            this.gbEffDetail.Controls.Add(this.lbVS);
            this.gbEffDetail.Controls.Add(this.lbEvents);
            this.gbEffDetail.Controls.Add(this.tbVS);
            this.gbEffDetail.Controls.Add(this.label1);
            this.gbEffDetail.Location = new System.Drawing.Point(2, 52);
            this.gbEffDetail.Name = "gbEffDetail";
            this.gbEffDetail.Size = new System.Drawing.Size(445, 337);
            this.gbEffDetail.TabIndex = 25;
            this.gbEffDetail.TabStop = false;
            this.gbEffDetail.Text = "特效细节";
            // 
            // btnSaveEffect
            // 
            this.btnSaveEffect.Location = new System.Drawing.Point(332, 395);
            this.btnSaveEffect.Name = "btnSaveEffect";
            this.btnSaveEffect.Size = new System.Drawing.Size(116, 26);
            this.btnSaveEffect.TabIndex = 26;
            this.btnSaveEffect.Text = "保存此特效";
            this.btnSaveEffect.UseVisualStyleBackColor = true;
            this.btnSaveEffect.Click += new System.EventHandler(this.btnSaveEffect_Click);
            // 
            // lbEffName
            // 
            this.lbEffName.AutoSize = true;
            this.lbEffName.Location = new System.Drawing.Point(7, 9);
            this.lbEffName.Name = "lbEffName";
            this.lbEffName.Size = new System.Drawing.Size(53, 12);
            this.lbEffName.TabIndex = 27;
            this.lbEffName.Text = "特效名称";
            // 
            // tbEffName
            // 
            this.tbEffName.Location = new System.Drawing.Point(9, 24);
            this.tbEffName.Name = "tbEffName";
            this.tbEffName.Size = new System.Drawing.Size(439, 21);
            this.tbEffName.TabIndex = 28;
            // 
            // AddNewEff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 429);
            this.Controls.Add(this.tbEffName);
            this.Controls.Add(this.lbEffName);
            this.Controls.Add(this.btnSaveEffect);
            this.Controls.Add(this.gbEffDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddNewEff";
            this.Text = "添加新特效";
            this.gbEffDetail.ResumeLayout(false);
            this.gbEffDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEvents;
        private System.Windows.Forms.TextBox tbEng;
        private System.Windows.Forms.Label lbEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVS;
        private System.Windows.Forms.Label lbVS;
        private System.Windows.Forms.TextBox tbSI;
        private System.Windows.Forms.Label lbSI;
        private System.Windows.Forms.GroupBox gbEffDetail;
        private System.Windows.Forms.Button btnSaveEffect;
        private System.Windows.Forms.Label lbEffName;
        private System.Windows.Forms.TextBox tbEffName;
    }
}