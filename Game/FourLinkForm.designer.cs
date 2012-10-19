namespace Game
{
    partial class FourLinkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FourLinkForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label4_score_total = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Game = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Round = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox_RouteChoice = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.route1 = new System.Windows.Forms.RadioButton();
            this.route2 = new System.Windows.Forms.RadioButton();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox_RouteChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "A network with four links connecting one OD pair";
            // 
            // groupbox
            // 
            this.groupbox.AutoSize = true;
            this.groupbox.BackColor = System.Drawing.Color.White;
            this.groupbox.Controls.Add(this.label4);
            this.groupbox.Controls.Add(this.label4_score_total);
            this.groupbox.Controls.Add(this.textBox2);
            this.groupbox.Controls.Add(this.label_Game);
            this.groupbox.Controls.Add(this.label5);
            this.groupbox.Controls.Add(this.label_Round);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.pictureBox3);
            this.groupbox.Controls.Add(this.groupBox_RouteChoice);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupbox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.Location = new System.Drawing.Point(12, 12);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(893, 396);
            this.groupbox.TabIndex = 9;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Four Link Game 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Game: 1";
            // 
            // label4_score_total
            // 
            this.label4_score_total.AutoSize = true;
            this.label4_score_total.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_score_total.ForeColor = System.Drawing.Color.Red;
            this.label4_score_total.Location = new System.Drawing.Point(690, 66);
            this.label4_score_total.Name = "label4_score_total";
            this.label4_score_total.Size = new System.Drawing.Size(19, 18);
            this.label4_score_total.TabIndex = 38;
            this.label4_score_total.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(512, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 37;
            this.textBox2.Text = "Remaining score:";
            // 
            // label_Game
            // 
            this.label_Game.AutoSize = true;
            this.label_Game.Location = new System.Drawing.Point(702, 28);
            this.label_Game.Name = "label_Game";
            this.label_Game.Size = new System.Drawing.Size(16, 16);
            this.label_Game.TabIndex = 36;
            this.label_Game.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Scenario:";
            // 
            // label_Round
            // 
            this.label_Round.AutoSize = true;
            this.label_Round.Location = new System.Drawing.Point(810, 28);
            this.label_Round.Name = "label_Round";
            this.label_Round.Size = new System.Drawing.Size(16, 16);
            this.label_Round.TabIndex = 33;
            this.label_Round.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Round:";
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
            this.pictureBox3.Location = new System.Drawing.Point(14, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(453, 228);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox_RouteChoice
            // 
            this.groupBox_RouteChoice.Controls.Add(this.pictureBox2);
            this.groupBox_RouteChoice.Controls.Add(this.pictureBox1);
            this.groupBox_RouteChoice.Controls.Add(this.button_Submit);
            this.groupBox_RouteChoice.Controls.Add(this.route1);
            this.groupBox_RouteChoice.Controls.Add(this.route2);
            this.groupBox_RouteChoice.Location = new System.Drawing.Point(512, 110);
            this.groupBox_RouteChoice.Name = "groupBox_RouteChoice";
            this.groupBox_RouteChoice.Size = new System.Drawing.Size(343, 232);
            this.groupBox_RouteChoice.TabIndex = 20;
            this.groupBox_RouteChoice.TabStop = false;
            this.groupBox_RouteChoice.Text = "Route Choice";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(162, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 46);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 46);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.Location = new System.Drawing.Point(19, 189);
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
            this.route2.Location = new System.Drawing.Point(19, 132);
            this.route2.Name = "route2";
            this.route2.Size = new System.Drawing.Size(132, 20);
            this.route2.TabIndex = 2;
            this.route2.TabStop = true;
            this.route2.Text = "route 2: O-B-D";
            this.route2.UseVisualStyleBackColor = true;
            // 
            // FourLinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 414);
            this.Controls.Add(this.groupbox);
            this.Name = "FourLinkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Four Link Network Game";
            this.Load += new System.EventHandler(this.FourLinkForm_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox_RouteChoice.ResumeLayout(false);
            this.groupBox_RouteChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.RadioButton route2;
        private System.Windows.Forms.RadioButton route1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.GroupBox groupBox_RouteChoice;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Round;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Game;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4_score_total;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;

    }
}