
namespace MydataClient
{
    partial class MakeKTfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_defaultFld = new System.Windows.Forms.TextBox();
            this.bt_default = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Yyyymmdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_targetFld = new System.Windows.Forms.TextBox();
            this.bt_TargetFld = new System.Windows.Forms.Button();
            this.tb_srcIa = new System.Windows.Forms.TextBox();
            this.tb_srcSa = new System.Windows.Forms.TextBox();
            this.gbSrc = new System.Windows.Forms.GroupBox();
            this.gbTarget = new System.Windows.Forms.GroupBox();
            this.tb_TargetIa = new System.Windows.Forms.TextBox();
            this.tb_TargetSa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btMake = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.gbSrc.SuspendLayout();
            this.gbTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "기본폴더: ";
            // 
            // tb_defaultFld
            // 
            this.tb_defaultFld.Location = new System.Drawing.Point(103, 54);
            this.tb_defaultFld.Name = "tb_defaultFld";
            this.tb_defaultFld.Size = new System.Drawing.Size(613, 25);
            this.tb_defaultFld.TabIndex = 1;
            // 
            // bt_default
            // 
            this.bt_default.Location = new System.Drawing.Point(722, 54);
            this.bt_default.Name = "bt_default";
            this.bt_default.Size = new System.Drawing.Size(75, 23);
            this.bt_default.TabIndex = 2;
            this.bt_default.Text = "폴더";
            this.bt_default.UseVisualStyleBackColor = true;
            this.bt_default.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "작업년월:";
            // 
            // tb_Yyyymmdd
            // 
            this.tb_Yyyymmdd.Location = new System.Drawing.Point(103, 19);
            this.tb_Yyyymmdd.Name = "tb_Yyyymmdd";
            this.tb_Yyyymmdd.Size = new System.Drawing.Size(126, 25);
            this.tb_Yyyymmdd.TabIndex = 4;
            this.tb_Yyyymmdd.TextChanged += new System.EventHandler(this.tb_Yyyymmdd_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "타겟폴더: ";
            // 
            // tb_targetFld
            // 
            this.tb_targetFld.Location = new System.Drawing.Point(103, 89);
            this.tb_targetFld.Name = "tb_targetFld";
            this.tb_targetFld.Size = new System.Drawing.Size(613, 25);
            this.tb_targetFld.TabIndex = 6;
            // 
            // bt_TargetFld
            // 
            this.bt_TargetFld.Location = new System.Drawing.Point(722, 91);
            this.bt_TargetFld.Name = "bt_TargetFld";
            this.bt_TargetFld.Size = new System.Drawing.Size(75, 23);
            this.bt_TargetFld.TabIndex = 7;
            this.bt_TargetFld.Text = "폴더";
            this.bt_TargetFld.UseVisualStyleBackColor = true;
            this.bt_TargetFld.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_srcIa
            // 
            this.tb_srcIa.Location = new System.Drawing.Point(16, 33);
            this.tb_srcIa.Name = "tb_srcIa";
            this.tb_srcIa.ReadOnly = true;
            this.tb_srcIa.Size = new System.Drawing.Size(198, 25);
            this.tb_srcIa.TabIndex = 8;
            // 
            // tb_srcSa
            // 
            this.tb_srcSa.Location = new System.Drawing.Point(16, 69);
            this.tb_srcSa.Name = "tb_srcSa";
            this.tb_srcSa.ReadOnly = true;
            this.tb_srcSa.Size = new System.Drawing.Size(198, 25);
            this.tb_srcSa.TabIndex = 9;
            // 
            // gbSrc
            // 
            this.gbSrc.Controls.Add(this.tb_srcIa);
            this.gbSrc.Controls.Add(this.tb_srcSa);
            this.gbSrc.Location = new System.Drawing.Point(20, 133);
            this.gbSrc.Name = "gbSrc";
            this.gbSrc.Size = new System.Drawing.Size(235, 100);
            this.gbSrc.TabIndex = 10;
            this.gbSrc.TabStop = false;
            this.gbSrc.Text = "Source";
            // 
            // gbTarget
            // 
            this.gbTarget.Controls.Add(this.tb_TargetIa);
            this.gbTarget.Controls.Add(this.tb_TargetSa);
            this.gbTarget.Location = new System.Drawing.Point(424, 133);
            this.gbTarget.Name = "gbTarget";
            this.gbTarget.Size = new System.Drawing.Size(235, 100);
            this.gbTarget.TabIndex = 11;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "Target";
            // 
            // tb_TargetIa
            // 
            this.tb_TargetIa.Location = new System.Drawing.Point(16, 33);
            this.tb_TargetIa.Name = "tb_TargetIa";
            this.tb_TargetIa.ReadOnly = true;
            this.tb_TargetIa.Size = new System.Drawing.Size(198, 25);
            this.tb_TargetIa.TabIndex = 8;
            // 
            // tb_TargetSa
            // 
            this.tb_TargetSa.Location = new System.Drawing.Point(16, 69);
            this.tb_TargetSa.Name = "tb_TargetSa";
            this.tb_TargetSa.ReadOnly = true;
            this.tb_TargetSa.Size = new System.Drawing.Size(198, 25);
            this.tb_TargetSa.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(320, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "==>";
            // 
            // btMake
            // 
            this.btMake.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btMake.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btMake.Location = new System.Drawing.Point(411, 12);
            this.btMake.Name = "btMake";
            this.btMake.Size = new System.Drawing.Size(179, 32);
            this.btMake.TabIndex = 13;
            this.btMake.Text = "파일생성";
            this.btMake.UseVisualStyleBackColor = true;
            this.btMake.Click += new System.EventHandler(this.btMake_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 280);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(793, 258);
            this.rtbLog.TabIndex = 14;
            this.rtbLog.Text = "";
            // 
            // MakeKTfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 550);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btMake);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbTarget);
            this.Controls.Add(this.gbSrc);
            this.Controls.Add(this.bt_TargetFld);
            this.Controls.Add(this.tb_targetFld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Yyyymmdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_default);
            this.Controls.Add(this.tb_defaultFld);
            this.Controls.Add(this.label1);
            this.Name = "MakeKTfile";
            this.Text = "KT재판매청구정보생성";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSrc.ResumeLayout(false);
            this.gbSrc.PerformLayout();
            this.gbTarget.ResumeLayout(false);
            this.gbTarget.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_defaultFld;
        private System.Windows.Forms.Button bt_default;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Yyyymmdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_targetFld;
        private System.Windows.Forms.Button bt_TargetFld;
        private System.Windows.Forms.TextBox tb_srcIa;
        private System.Windows.Forms.TextBox tb_srcSa;
        private System.Windows.Forms.GroupBox gbSrc;
        private System.Windows.Forms.GroupBox gbTarget;
        private System.Windows.Forms.TextBox tb_TargetIa;
        private System.Windows.Forms.TextBox tb_TargetSa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btMake;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}