namespace Game
{
    partial class FiveLinkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiveLinkForm));
            this.label_add = new System.Windows.Forms.Label();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5_score_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_round = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_game = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox_RouteChoice = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.route3 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.route1 = new System.Windows.Forms.RadioButton();
            this.route2 = new System.Windows.Forms.RadioButton();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox_RouteChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_add
            // 
            this.label_add.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add.ForeColor = System.Drawing.Color.Red;
            this.label_add.Location = new System.Drawing.Point(24, 33);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(407, 22);
            this.label_add.TabIndex = 0;
            this.label_add.Text = "Now a new bridge is built between A and B...";
            // 
            // groupbox
            // 
            this.groupbox.AutoSize = true;
            this.groupbox.BackColor = System.Drawing.Color.White;
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Controls.Add(this.label5_score_total);
            this.groupbox.Controls.Add(this.label6);
            this.groupbox.Controls.Add(this.label4);
            this.groupbox.Controls.Add(this.textBox2);
            this.groupbox.Controls.Add(this.label_round);
            this.groupbox.Controls.Add(this.label5);
            this.groupbox.Controls.Add(this.label_game);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.pictureBox3);
            this.groupbox.Controls.Add(this.groupBox_RouteChoice);
            this.groupbox.Controls.Add(this.label_add);
            this.groupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupbox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.Location = new System.Drawing.Point(12, 12);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(893, 416);
            this.groupbox.TabIndex = 9;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Five Link Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Game: 1";
            // 
            // label5_score_total
            // 
            this.label5_score_total.AutoSize = true;
            this.label5_score_total.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_score_total.ForeColor = System.Drawing.Color.Red;
            this.label5_score_total.Location = new System.Drawing.Point(693, 58);
            this.label5_score_total.Name = "label5_score_total";
            this.label5_score_total.Size = new System.Drawing.Size(19, 18);
            this.label5_score_total.TabIndex = 40;
            this.label5_score_total.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(818, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "2";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(515, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "Remaining score:";
            // 
            // label_round
            // 
            this.label_round.AutoSize = true;
            this.label_round.Location = new System.Drawing.Point(821, 19);
            this.label_round.Name = "label_round";
            this.label_round.Size = new System.Drawing.Size(0, 16);
            this.label_round.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(758, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Round:";
            // 
            // label_game
            // 
            this.label_game.AutoSize = true;
            this.label_game.Location = new System.Drawing.Point(709, 19);
            this.label_game.Name = "label_game";
            this.label_game.Size = new System.Drawing.Size(0, 16);
            this.label_game.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Scenario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 22;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 126);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(453, 228);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox_RouteChoice
            // 
            this.groupBox_RouteChoice.Controls.Add(this.pictureBox4);
            this.groupBox_RouteChoice.Controls.Add(this.route3);
            this.groupBox_RouteChoice.Controls.Add(this.pictureBox2);
            this.groupBox_RouteChoice.Controls.Add(this.pictureBox1);
            this.groupBox_RouteChoice.Controls.Add(this.button_Submit);
            this.groupBox_RouteChoice.Controls.Add(this.route1);
            this.groupBox_RouteChoice.Controls.Add(this.route2);
            this.groupBox_RouteChoice.Location = new System.Drawing.Point(515, 94);
            this.groupBox_RouteChoice.Name = "groupBox_RouteChoice";
            this.groupBox_RouteChoice.Size = new System.Drawing.Size(343, 294);
            this.groupBox_RouteChoice.TabIndex = 20;
            this.groupBox_RouteChoice.TabStop = false;
            this.groupBox_RouteChoice.Text = "Route Choice";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(171, 163);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 51);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // route3
            // 
            this.route3.AutoSize = true;
            this.route3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.route3.ForeColor = System.Drawing.Color.Red;
            this.route3.Location = new System.Drawing.Point(18, 175);
            this.route3.Name = "route3";
            this.route3.Size = new System.Drawing.Size(149, 20);
            this.route3.TabIndex = 19;
            this.route3.TabStop = true;
            this.route3.Text = "route 3: O-A-B-D";
            this.route3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(170, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 46);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 46);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.Location = new System.Drawing.Point(17, 237);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(90, 37);
            this.button_Submit.TabIndex = 18;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // route1
            // 
            this.route1.AutoSize = true;
            this.route1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.route1.ForeColor = System.Drawing.Color.Red;
            this.route1.Location = new System.Drawing.Point(18, 48);
            this.route1.Name = "route1";
            this.route1.Size = new System.Drawing.Size(132, 20);
            this.route1.TabIndex = 1;
            this.route1.TabStop = true;
            this.route1.Text = "route 1: O-A-D";
            this.route1.UseVisualStyleBackColor = true;
            // 
            // route2
            // 
            this.route2.AutoSize = true;
            this.route2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.route2.ForeColor = System.Drawing.Color.Red;
            this.route2.Location = new System.Drawing.Point(19, 110);
            this.route2.Name = "route2";
            this.route2.Size = new System.Drawing.Size(132, 20);
            this.route2.TabIndex = 2;
            this.route2.TabStop = true;
            this.route2.Text = "route 2: O-B-D";
            this.route2.UseVisualStyleBackColor = true;
            // 
            // FiveLinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 432);
            this.Controls.Add(this.groupbox);
            this.Name = "FiveLinkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Five Link Network Game";
            this.Load += new System.EventHandler(this.FiveLinkForm_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox_RouteChoice.ResumeLayout(false);
            this.groupBox_RouteChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.RadioButton route2;
        private System.Windows.Forms.RadioButton route1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.GroupBox groupBox_RouteChoice;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_game;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton route3;
        private System.Windows.Forms.Label label_round;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5_score_total;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;

    }
}