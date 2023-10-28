using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class BölümlerForm : Form
    {
        public BölümlerForm()
        {
            InitializeComponent();
        }
        Form1 frm1 = new Form1();

        private void DegiskenBbuton_Click(object sender, EventArgs e)
        {
            frm1.Show();
            frm1.bölüm = "degisken";
            this.Hide();

        }

        private void SabitBbuton_Click(object sender, EventArgs e)
        {
            frm1.Show();
            frm1.bölüm = "sabit";
            this.Hide();
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
