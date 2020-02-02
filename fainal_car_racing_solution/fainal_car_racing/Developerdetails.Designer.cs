namespace fainal_car_racing
{
    partial class Developerdetails
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.enemy_2 = new System.Windows.Forms.PictureBox();
            this.enemy_3 = new System.Windows.Forms.PictureBox();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.start_btn = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 304);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(472, 101);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "I have completed my Diploma Engineering   from Bogra polytechnic institute . And " +
                "I am a professional Mobile and Desktop Application Developer over 3 years of exp" +
                "erience.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 220);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 41);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "This game was created by Engineer Mohammad:Baijid Hossain .";
            // 
            // enemy_2
            // 
            this.enemy_2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.enemy_2.BackgroundImage = global::fainal_car_racing.Properties.Resources.Car_Top_Red_icon34;
            this.enemy_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy_2.Location = new System.Drawing.Point(128, 44);
            this.enemy_2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.enemy_2.Name = "enemy_2";
            this.enemy_2.Size = new System.Drawing.Size(34, 99);
            this.enemy_2.TabIndex = 13;
            this.enemy_2.TabStop = false;
            // 
            // enemy_3
            // 
            this.enemy_3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.enemy_3.BackgroundImage = global::fainal_car_racing.Properties.Resources.Car_Top_Red_icon44;
            this.enemy_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy_3.Location = new System.Drawing.Point(316, 43);
            this.enemy_3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.enemy_3.Name = "enemy_3";
            this.enemy_3.Size = new System.Drawing.Size(34, 99);
            this.enemy_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy_3.TabIndex = 14;
            this.enemy_3.TabStop = false;
            this.enemy_3.Click += new System.EventHandler(this.enemy_3_Click);
            // 
            // enemy_1
            // 
            this.enemy_1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.enemy_1.BackgroundImage = global::fainal_car_racing.Properties.Resources.Car_Top_Red_icon33;
            this.enemy_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy_1.Location = new System.Drawing.Point(398, 43);
            this.enemy_1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.enemy_1.Name = "enemy_1";
            this.enemy_1.Size = new System.Drawing.Size(34, 99);
            this.enemy_1.TabIndex = 15;
            this.enemy_1.TabStop = false;
            this.enemy_1.Tag = "";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.HighlightText;
            this.player.BackgroundImage = global::fainal_car_racing.Properties.Resources.Car_Top_Red_icon2;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(215, 30);
            this.player.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(44, 113);
            this.player.TabIndex = 16;
            this.player.TabStop = false;
            // 
            // start_btn
            // 
            this.start_btn.AutoSize = true;
            this.start_btn.Location = new System.Drawing.Point(24, 43);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(46, 17);
            this.start_btn.TabIndex = 17;
            this.start_btn.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.start_btn);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.enemy_2);
            this.groupBox2.Controls.Add(this.enemy_1);
            this.groupBox2.Controls.Add(this.player);
            this.groupBox2.Controls.Add(this.enemy_3);
            this.groupBox2.Location = new System.Drawing.Point(3, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 477);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Developerdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(517, 653);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Developerdetails";
            this.Text = "Developerdetails";
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox enemy_2;
        private System.Windows.Forms.PictureBox enemy_3;
        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label start_btn;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}