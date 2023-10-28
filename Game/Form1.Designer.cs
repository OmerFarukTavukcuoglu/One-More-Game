namespace Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RaundTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.WinPanel = new System.Windows.Forms.Panel();
            this.SabitBbuton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FinalSkorLabelSonuc = new System.Windows.Forms.Label();
            this.FinalSkorLabel = new System.Windows.Forms.Label();
            this.TekrarButon = new System.Windows.Forms.Button();
            this.CircleButton = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.TekrarDesignTimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DurVeDevamBtn = new System.Windows.Forms.Button();
            this.AnaMenuBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PuanLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.WinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RaundTime
            // 
            this.RaundTime.Tick += new System.EventHandler(this.RaundTime_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.WinPanel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.FinalSkorLabelSonuc);
            this.panel1.Controls.Add(this.FinalSkorLabel);
            this.panel1.Controls.Add(this.TekrarButon);
            this.panel1.Controls.Add(this.CircleButton);
            this.panel1.Location = new System.Drawing.Point(190, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 750);
            this.panel1.TabIndex = 5;
            // 
            // WinPanel
            // 
            this.WinPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.WinPanel.Controls.Add(this.SabitBbuton);
            this.WinPanel.Controls.Add(this.label6);
            this.WinPanel.Controls.Add(this.pictureBox3);
            this.WinPanel.Location = new System.Drawing.Point(391, 134);
            this.WinPanel.Name = "WinPanel";
            this.WinPanel.Size = new System.Drawing.Size(393, 420);
            this.WinPanel.TabIndex = 16;
            // 
            // SabitBbuton
            // 
            this.SabitBbuton.BackColor = System.Drawing.Color.Yellow;
            this.SabitBbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SabitBbuton.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SabitBbuton.Location = new System.Drawing.Point(32, 353);
            this.SabitBbuton.Name = "SabitBbuton";
            this.SabitBbuton.Size = new System.Drawing.Size(331, 53);
            this.SabitBbuton.TabIndex = 20;
            this.SabitBbuton.Text = "Tekrar Oyma";
            this.SabitBbuton.UseVisualStyleBackColor = false;
            this.SabitBbuton.Click += new System.EventHandler(this.SabitBbuton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(39, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 46);
            this.label6.TabIndex = 19;
            this.label6.Text = "Oyunu Kazandın!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(69, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(328, 261);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Location = new System.Drawing.Point(188, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(436, 434);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // FinalSkorLabelSonuc
            // 
            this.FinalSkorLabelSonuc.AutoSize = true;
            this.FinalSkorLabelSonuc.BackColor = System.Drawing.Color.Transparent;
            this.FinalSkorLabelSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 85F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FinalSkorLabelSonuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FinalSkorLabelSonuc.Location = new System.Drawing.Point(616, 596);
            this.FinalSkorLabelSonuc.Name = "FinalSkorLabelSonuc";
            this.FinalSkorLabelSonuc.Size = new System.Drawing.Size(118, 128);
            this.FinalSkorLabelSonuc.TabIndex = 15;
            this.FinalSkorLabelSonuc.Text = "0";
            this.FinalSkorLabelSonuc.Visible = false;
            // 
            // FinalSkorLabel
            // 
            this.FinalSkorLabel.AutoSize = true;
            this.FinalSkorLabel.BackColor = System.Drawing.Color.Transparent;
            this.FinalSkorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FinalSkorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FinalSkorLabel.Location = new System.Drawing.Point(303, 598);
            this.FinalSkorLabel.Name = "FinalSkorLabel";
            this.FinalSkorLabel.Size = new System.Drawing.Size(321, 128);
            this.FinalSkorLabel.TabIndex = 12;
            this.FinalSkorLabel.Text = "Skor:";
            this.FinalSkorLabel.Visible = false;
            // 
            // TekrarButon
            // 
            this.TekrarButon.BackColor = System.Drawing.Color.White;
            this.TekrarButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TekrarButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TekrarButon.Location = new System.Drawing.Point(296, 134);
            this.TekrarButon.Name = "TekrarButon";
            this.TekrarButon.Size = new System.Drawing.Size(731, 434);
            this.TekrarButon.TabIndex = 10;
            this.TekrarButon.Text = "                             TEKRAR OYNA !";
            this.TekrarButon.UseVisualStyleBackColor = false;
            this.TekrarButon.Click += new System.EventHandler(this.TekrarButon_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.animated = false;
            this.CircleButton.animationIterval = 5;
            this.CircleButton.animationSpeed = 50;
            this.CircleButton.BackColor = System.Drawing.Color.Transparent;
            this.CircleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleButton.BackgroundImage")));
            this.CircleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1E-05F);
            this.CircleButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.CircleButton.LabelVisible = false;
            this.CircleButton.LineProgressThickness = 8;
            this.CircleButton.LineThickness = 5;
            this.CircleButton.Location = new System.Drawing.Point(356, 18);
            this.CircleButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.CircleButton.MaxValue = 100;
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.ProgressBackColor = System.Drawing.Color.White;
            this.CircleButton.ProgressColor = System.Drawing.Color.SpringGreen;
            this.CircleButton.Size = new System.Drawing.Size(228, 228);
            this.CircleButton.TabIndex = 0;
            this.CircleButton.Value = 0;
            this.CircleButton.Paint += new System.Windows.Forms.PaintEventHandler(this.CircleButton_Paint);
            this.CircleButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleButton_MouseMove);
            // 
            // TekrarDesignTimer
            // 
            this.TekrarDesignTimer.Tick += new System.EventHandler(this.TekrarDesignTimer_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.DurVeDevamBtn);
            this.bunifuGradientPanel1.Controls.Add(this.AnaMenuBtn);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.PuanLabel);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Yellow;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowText;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.WindowFrame;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(192, 750);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // DurVeDevamBtn
            // 
            this.DurVeDevamBtn.BackColor = System.Drawing.Color.Khaki;
            this.DurVeDevamBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DurVeDevamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DurVeDevamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurVeDevamBtn.Location = new System.Drawing.Point(-2, 493);
            this.DurVeDevamBtn.Name = "DurVeDevamBtn";
            this.DurVeDevamBtn.Size = new System.Drawing.Size(194, 48);
            this.DurVeDevamBtn.TabIndex = 14;
            this.DurVeDevamBtn.Text = "        Oyunu Durdur";
            this.DurVeDevamBtn.UseVisualStyleBackColor = false;
            this.DurVeDevamBtn.Click += new System.EventHandler(this.DurVeDevamBtn_Click);
            // 
            // AnaMenuBtn
            // 
            this.AnaMenuBtn.BackColor = System.Drawing.Color.Khaki;
            this.AnaMenuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AnaMenuBtn.BackgroundImage")));
            this.AnaMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AnaMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnaMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaMenuBtn.Location = new System.Drawing.Point(-2, 445);
            this.AnaMenuBtn.Name = "AnaMenuBtn";
            this.AnaMenuBtn.Size = new System.Drawing.Size(194, 48);
            this.AnaMenuBtn.TabIndex = 13;
            this.AnaMenuBtn.Text = "Anasayfa";
            this.AnaMenuBtn.UseVisualStyleBackColor = false;
            this.AnaMenuBtn.Click += new System.EventHandler(this.AnaMenuBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Seviye :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(0, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "One More Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // PuanLabel
            // 
            this.PuanLabel.AutoSize = true;
            this.PuanLabel.BackColor = System.Drawing.Color.Transparent;
            this.PuanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PuanLabel.Location = new System.Drawing.Point(96, 347);
            this.PuanLabel.Name = "PuanLabel";
            this.PuanLabel.Size = new System.Drawing.Size(23, 25);
            this.PuanLabel.TabIndex = 7;
            this.PuanLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Puan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(97, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kalan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(96, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Level1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 728);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.WinPanel.ResumeLayout(false);
            this.WinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer RaundTime;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CircleButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PuanLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TekrarButon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button DurVeDevamBtn;
        private System.Windows.Forms.Button AnaMenuBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label FinalSkorLabelSonuc;
        private System.Windows.Forms.Label FinalSkorLabel;
        private System.Windows.Forms.Timer TekrarDesignTimer;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel WinPanel;
        public System.Windows.Forms.Button SabitBbuton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

