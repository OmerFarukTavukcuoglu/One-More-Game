namespace Game
{
    partial class BölümlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BölümlerForm));
            this.button1 = new System.Windows.Forms.Button();
            this.SabitBbuton = new System.Windows.Forms.Button();
            this.DegiskenBbuton = new System.Windows.Forms.Button();
            this.KapatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(-2, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(505, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Bölümler";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SabitBbuton
            // 
            this.SabitBbuton.BackColor = System.Drawing.Color.Yellow;
            this.SabitBbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SabitBbuton.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SabitBbuton.Location = new System.Drawing.Point(77, 65);
            this.SabitBbuton.Name = "SabitBbuton";
            this.SabitBbuton.Size = new System.Drawing.Size(331, 53);
            this.SabitBbuton.TabIndex = 16;
            this.SabitBbuton.Text = "Sabit Boyut";
            this.SabitBbuton.UseVisualStyleBackColor = false;
            this.SabitBbuton.Click += new System.EventHandler(this.SabitBbuton_Click);
            // 
            // DegiskenBbuton
            // 
            this.DegiskenBbuton.BackColor = System.Drawing.Color.Yellow;
            this.DegiskenBbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DegiskenBbuton.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DegiskenBbuton.Location = new System.Drawing.Point(77, 165);
            this.DegiskenBbuton.Name = "DegiskenBbuton";
            this.DegiskenBbuton.Size = new System.Drawing.Size(331, 53);
            this.DegiskenBbuton.TabIndex = 17;
            this.DegiskenBbuton.Text = "Değişken Boyut";
            this.DegiskenBbuton.UseVisualStyleBackColor = false;
            this.DegiskenBbuton.Click += new System.EventHandler(this.DegiskenBbuton_Click);
            // 
            // KapatLabel
            // 
            this.KapatLabel.AutoSize = true;
            this.KapatLabel.BackColor = System.Drawing.Color.Yellow;
            this.KapatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KapatLabel.Location = new System.Drawing.Point(450, -2);
            this.KapatLabel.Name = "KapatLabel";
            this.KapatLabel.Size = new System.Drawing.Size(33, 31);
            this.KapatLabel.TabIndex = 28;
            this.KapatLabel.Text = "X";
            this.KapatLabel.Click += new System.EventHandler(this.KapatLabel_Click);
            this.KapatLabel.MouseLeave += new System.EventHandler(this.KapatLabel_MouseLeave);
            this.KapatLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KapatLabel_MouseMove);
            // 
            // BölümlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(486, 255);
            this.Controls.Add(this.KapatLabel);
            this.Controls.Add(this.DegiskenBbuton);
            this.Controls.Add(this.SabitBbuton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BölümlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BölümlerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button SabitBbuton;
        public System.Windows.Forms.Button DegiskenBbuton;
        private System.Windows.Forms.Label KapatLabel;
    }
}