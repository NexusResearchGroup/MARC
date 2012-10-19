namespace LabCommServer
{
    partial class LabServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.strID = new System.Windows.Forms.ColumnHeader();
            this.txtInfor = new System.Windows.Forms.RichTextBox();
            this.textBox_playerNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_round_1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_IP = new System.Windows.Forms.ComboBox();
            this.comboBox_DB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_round = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_round_trial = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(830, 7);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(64, 39);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Players";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picStatus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(614, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 31);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // picStatus
            // 
            this.picStatus.Location = new System.Drawing.Point(167, 11);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(16, 17);
            this.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatus.TabIndex = 6;
            this.picStatus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Server Idle";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.strID});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(33, 139);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(209, 395);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // strID
            // 
            this.strID.Text = "ID";
            this.strID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.strID.Width = 96;
            // 
            // txtInfor
            // 
            this.txtInfor.Location = new System.Drawing.Point(259, 139);
            this.txtInfor.Name = "txtInfor";
            this.txtInfor.Size = new System.Drawing.Size(650, 395);
            this.txtInfor.TabIndex = 15;
            this.txtInfor.Text = "";
            // 
            // textBox_playerNo
            // 
            this.textBox_playerNo.Location = new System.Drawing.Point(88, 20);
            this.textBox_playerNo.Name = "textBox_playerNo";
            this.textBox_playerNo.Size = new System.Drawing.Size(32, 20);
            this.textBox_playerNo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Players No.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total Round for scenario 1:";
            // 
            // textBox_round_1
            // 
            this.textBox_round_1.Location = new System.Drawing.Point(286, 55);
            this.textBox_round_1.Name = "textBox_round_1";
            this.textBox_round_1.Size = new System.Drawing.Size(32, 20);
            this.textBox_round_1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "IP Address:";
            // 
            // comboBox_IP
            // 
            this.comboBox_IP.AllowDrop = true;
            this.comboBox_IP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_IP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_IP.FormattingEnabled = true;
            this.comboBox_IP.Items.AddRange(new object[] {
            "134.84.148.222",
            "134.84.73.132",
            "192.168.0.101"});
            this.comboBox_IP.Location = new System.Drawing.Point(412, 19);
            this.comboBox_IP.Name = "comboBox_IP";
            this.comboBox_IP.Size = new System.Drawing.Size(121, 21);
            this.comboBox_IP.TabIndex = 21;
            // 
            // comboBox_DB
            // 
            this.comboBox_DB.AllowDrop = true;
            this.comboBox_DB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DB.FormattingEnabled = true;
            this.comboBox_DB.Items.AddRange(new object[] {
            "UNIVERSI-9CB70F\\SQLEXPRESS",
            "XUANDI\\SQLEXPRESS"});
            this.comboBox_DB.Location = new System.Drawing.Point(409, 61);
            this.comboBox_DB.Name = "comboBox_DB";
            this.comboBox_DB.Size = new System.Drawing.Size(194, 21);
            this.comboBox_DB.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Database:";
            // 
            // textBox_round
            // 
            this.textBox_round.Location = new System.Drawing.Point(286, 93);
            this.textBox_round.Name = "textBox_round";
            this.textBox_round.Size = new System.Drawing.Size(32, 20);
            this.textBox_round.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Total Round for scenario 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Route choice Transmission Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Total Round for trial :";
            // 
            // textBox_round_trial
            // 
            this.textBox_round_trial.Location = new System.Drawing.Point(286, 18);
            this.textBox_round_trial.Name = "textBox_round_trial";
            this.textBox_round_trial.Size = new System.Drawing.Size(32, 20);
            this.textBox_round_trial.TabIndex = 27;
            // 
            // LabServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 546);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_round_trial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_round);
            this.Controls.Add(this.comboBox_DB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_IP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_round_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_playerNo);
            this.Controls.Add(this.txtInfor);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LabServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game1";
            this.Load += new System.EventHandler(this.LabServer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RichTextBox txtInfor;
        private System.Windows.Forms.ColumnHeader strID;
        private System.Windows.Forms.TextBox textBox_playerNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_round_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_IP;
        private System.Windows.Forms.ComboBox comboBox_DB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_round;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_round_trial;
    }
}