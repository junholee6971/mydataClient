
namespace WindowsFormsApp1
{
    partial class MydataWindow
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ci = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_reqMsg = new System.Windows.Forms.RichTextBox();
            this.rtb_rcvMsg = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_CreateMsg = new System.Windows.Forms.Button();
            this.bt_reqSaid = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gb_IL = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_remainCnt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_reqCnt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_IB = new System.Windows.Forms.GroupBox();
            this.tb_fromInvMonth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gb_IT = new System.Windows.Forms.GroupBox();
            this.tb_toPmtMonth = new System.Windows.Forms.TextBox();
            this.tb_fromPmtMonth = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_said = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_toInvMonth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gb_IL.SuspendLayout();
            this.gb_IB.SuspendLayout();
            this.gb_IT.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IB - 청구정보전문",
            "ID - 본인확인전문",
            "IL - 계약목록전문",
            "IS - 상태조회전문",
            "IT - 거래내역조회"});
            this.comboBox1.Location = new System.Drawing.Point(156, 266);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(20, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message Type :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(850, 171);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(23, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "CI 조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(20, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select CI :";
            // 
            // tb_ci
            // 
            this.tb_ci.Location = new System.Drawing.Point(100, 235);
            this.tb_ci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ci.Name = "tb_ci";
            this.tb_ci.Size = new System.Drawing.Size(774, 21);
            this.tb_ci.TabIndex = 5;
            this.tb_ci.Text = "   ";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(20, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Send Msg :";
            // 
            // rtb_reqMsg
            // 
            this.rtb_reqMsg.Location = new System.Drawing.Point(100, 384);
            this.rtb_reqMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtb_reqMsg.Name = "rtb_reqMsg";
            this.rtb_reqMsg.Size = new System.Drawing.Size(774, 88);
            this.rtb_reqMsg.TabIndex = 7;
            this.rtb_reqMsg.Text = "";
            // 
            // rtb_rcvMsg
            // 
            this.rtb_rcvMsg.Location = new System.Drawing.Point(100, 526);
            this.rtb_rcvMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtb_rcvMsg.Name = "rtb_rcvMsg";
            this.rtb_rcvMsg.Size = new System.Drawing.Size(774, 88);
            this.rtb_rcvMsg.TabIndex = 9;
            this.rtb_rcvMsg.Text = "";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(20, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Recv Msg :";
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(780, 494);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "MSG 전송";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_CreateMsg
            // 
            this.bt_CreateMsg.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bt_CreateMsg.Location = new System.Drawing.Point(780, 351);
            this.bt_CreateMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_CreateMsg.Name = "bt_CreateMsg";
            this.bt_CreateMsg.Size = new System.Drawing.Size(93, 27);
            this.bt_CreateMsg.TabIndex = 11;
            this.bt_CreateMsg.Text = "MSG 생성";
            this.bt_CreateMsg.UseVisualStyleBackColor = true;
            this.bt_CreateMsg.Click += new System.EventHandler(this.bt_CreateMsg_Click);
            // 
            // bt_reqSaid
            // 
            this.bt_reqSaid.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bt_reqSaid.Location = new System.Drawing.Point(886, 190);
            this.bt_reqSaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_reqSaid.Name = "bt_reqSaid";
            this.bt_reqSaid.Size = new System.Drawing.Size(105, 27);
            this.bt_reqSaid.TabIndex = 12;
            this.bt_reqSaid.Text = " >> Said 조회";
            this.bt_reqSaid.UseVisualStyleBackColor = true;
            this.bt_reqSaid.Click += new System.EventHandler(this.bt_reqSaid_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1001, 16);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(164, 626);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // gb_IL
            // 
            this.gb_IL.BackColor = System.Drawing.Color.Green;
            this.gb_IL.CausesValidation = false;
            this.gb_IL.Controls.Add(this.label8);
            this.gb_IL.Controls.Add(this.label7);
            this.gb_IL.Controls.Add(this.tb_remainCnt);
            this.gb_IL.Controls.Add(this.label6);
            this.gb_IL.Controls.Add(this.tb_reqCnt);
            this.gb_IL.Controls.Add(this.label5);
            this.gb_IL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_IL.Location = new System.Drawing.Point(23, 293);
            this.gb_IL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_IL.Name = "gb_IL";
            this.gb_IL.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_IL.Size = new System.Drawing.Size(850, 54);
            this.gb_IL.TabIndex = 14;
            this.gb_IL.TabStop = false;
            this.gb_IL.Text = "계약목록 전문관련";
            this.gb_IL.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(558, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "(최초조회시 공백, 조회하고 남은 건수)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(160, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "(요청건수로 최대건수 500)";
            // 
            // tb_remainCnt
            // 
            this.tb_remainCnt.Location = new System.Drawing.Point(477, 22);
            this.tb_remainCnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_remainCnt.MaxLength = 4;
            this.tb_remainCnt.Name = "tb_remainCnt";
            this.tb_remainCnt.Size = new System.Drawing.Size(77, 21);
            this.tb_remainCnt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(390, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "잔여건수 :";
            // 
            // tb_reqCnt
            // 
            this.tb_reqCnt.Location = new System.Drawing.Point(114, 23);
            this.tb_reqCnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_reqCnt.MaxLength = 3;
            this.tb_reqCnt.Name = "tb_reqCnt";
            this.tb_reqCnt.Size = new System.Drawing.Size(42, 21);
            this.tb_reqCnt.TabIndex = 1;
            this.tb_reqCnt.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "요청건수 :";
            // 
            // gb_IB
            // 
            this.gb_IB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_IB.Controls.Add(this.tb_toInvMonth);
            this.gb_IB.Controls.Add(this.label12);
            this.gb_IB.Controls.Add(this.tb_fromInvMonth);
            this.gb_IB.Controls.Add(this.label9);
            this.gb_IB.Location = new System.Drawing.Point(20, 649);
            this.gb_IB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_IB.Name = "gb_IB";
            this.gb_IB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_IB.Size = new System.Drawing.Size(374, 54);
            this.gb_IB.TabIndex = 19;
            this.gb_IB.TabStop = false;
            this.gb_IB.Text = "청구정보 조회전문";
            // 
            // tb_fromInvMonth
            // 
            this.tb_fromInvMonth.AcceptsReturn = true;
            this.tb_fromInvMonth.AcceptsTab = true;
            this.tb_fromInvMonth.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_fromInvMonth.Location = new System.Drawing.Point(112, 20);
            this.tb_fromInvMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_fromInvMonth.MaxLength = 6;
            this.tb_fromInvMonth.Name = "tb_fromInvMonth";
            this.tb_fromInvMonth.Size = new System.Drawing.Size(109, 21);
            this.tb_fromInvMonth.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "조회 청구년월 :";
            // 
            // gb_IT
            // 
            this.gb_IT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gb_IT.Controls.Add(this.tb_toPmtMonth);
            this.gb_IT.Controls.Add(this.tb_fromPmtMonth);
            this.gb_IT.Controls.Add(this.label11);
            this.gb_IT.Controls.Add(this.label10);
            this.gb_IT.Location = new System.Drawing.Point(400, 649);
            this.gb_IT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_IT.Name = "gb_IT";
            this.gb_IT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_IT.Size = new System.Drawing.Size(576, 54);
            this.gb_IT.TabIndex = 20;
            this.gb_IT.TabStop = false;
            this.gb_IT.Text = " 거래내역 조회전문";
            // 
            // tb_toPmtMonth
            // 
            this.tb_toPmtMonth.Location = new System.Drawing.Point(388, 22);
            this.tb_toPmtMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_toPmtMonth.MaxLength = 6;
            this.tb_toPmtMonth.Name = "tb_toPmtMonth";
            this.tb_toPmtMonth.Size = new System.Drawing.Size(88, 21);
            this.tb_toPmtMonth.TabIndex = 22;
            // 
            // tb_fromPmtMonth
            // 
            this.tb_fromPmtMonth.Location = new System.Drawing.Point(143, 22);
            this.tb_fromPmtMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_fromPmtMonth.MaxLength = 6;
            this.tb_fromPmtMonth.Name = "tb_fromPmtMonth";
            this.tb_fromPmtMonth.Size = new System.Drawing.Size(88, 21);
            this.tb_fromPmtMonth.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "조회종료 수납년월 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "조회시작 수납년월 :";
            // 
            // tb_said
            // 
            this.tb_said.Location = new System.Drawing.Point(878, 270);
            this.tb_said.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_said.Name = "tb_said";
            this.tb_said.Size = new System.Drawing.Size(88, 21);
            this.tb_said.TabIndex = 21;
            this.tb_said.Visible = false;
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(620, 494);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 27);
            this.button3.TabIndex = 22;
            this.button3.Text = "리턴MSG Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(780, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 24);
            this.button4.TabIndex = 23;
            this.button4.Text = "KT재판매청구파일생성";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "~";
            // 
            // tb_toInvMonth
            // 
            this.tb_toInvMonth.AcceptsReturn = true;
            this.tb_toInvMonth.AcceptsTab = true;
            this.tb_toInvMonth.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_toInvMonth.Location = new System.Drawing.Point(237, 20);
            this.tb_toInvMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_toInvMonth.MaxLength = 6;
            this.tb_toInvMonth.Name = "tb_toInvMonth";
            this.tb_toInvMonth.Size = new System.Drawing.Size(109, 21);
            this.tb_toInvMonth.TabIndex = 22;
            // 
            // MydataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 715);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_said);
            this.Controls.Add(this.gb_IT);
            this.Controls.Add(this.gb_IB);
            this.Controls.Add(this.gb_IL);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bt_reqSaid);
            this.Controls.Add(this.bt_CreateMsg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rtb_rcvMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtb_reqMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_ci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MydataWindow";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gb_IL.ResumeLayout(false);
            this.gb_IL.PerformLayout();
            this.gb_IB.ResumeLayout(false);
            this.gb_IB.PerformLayout();
            this.gb_IT.ResumeLayout(false);
            this.gb_IT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_reqMsg;
        private System.Windows.Forms.RichTextBox rtb_rcvMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_CreateMsg;
        private System.Windows.Forms.Button bt_reqSaid;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gb_IL;
        private System.Windows.Forms.TextBox tb_remainCnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_reqCnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gb_IB;
        private System.Windows.Forms.TextBox tb_fromInvMonth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gb_IT;
        private System.Windows.Forms.TextBox tb_toPmtMonth;
        private System.Windows.Forms.TextBox tb_fromPmtMonth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_said;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_toInvMonth;
        private System.Windows.Forms.Label label12;
    }
}

