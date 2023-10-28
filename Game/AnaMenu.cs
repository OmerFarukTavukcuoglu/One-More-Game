using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
           
            InitializeComponent();
        }

        private void BaslaBtn_Click(object sender, EventArgs e)
        {

            BölümlerForm BF = new BölümlerForm();
            BF.Show();
            this.Hide();
        }

        public int RotateAngle { get; set; }
        public string NewText { get; set; }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
           
            Brush b = new SolidBrush(this.ForeColor);
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(this.RotateAngle);
            e.Graphics.DrawString(this.NewText, this.Font, b, 0f, 0f);
            e.Graphics.RotateTransform(90);
            base.OnPaint(e);

        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.WheelsGif;
            label1.Text = "";
            label1.AutoSize = false;
            label1.ForeColor = Color.Green;
         }

        private void BaslaBtn_MouseMove(object sender, MouseEventArgs e)
        {
            BaslaBtn.BackColor = Color.Gold;
            label1.BackColor = Color.Gold;
            label2.BackColor = Color.Gold;
            label3.BackColor = Color.Gold;
            label4.BackColor = Color.Gold;
            label5.BackColor = Color.Gold;
            label7.BackColor = Color.Gold;
        }

        private void BaslaBtn_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            label4.BackColor = Color.White;
            label5.BackColor = Color.White;
            label7.BackColor = Color.White;

        }

        private void KapatLabel_MouseMove(object sender, MouseEventArgs e)
        {
            KapatLabel.ForeColor = Color.Red;

        }

        private void KapatLabel_MouseLeave(object sender, EventArgs e)
        {
            KapatLabel.ForeColor = Color.Black;
        }

        private void KapatLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
