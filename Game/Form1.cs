using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.IO;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WinPanel.Visible = false;
            pictureBox2.Visible = false;
            yenidenBtn(false);
         }
        SoundPlayer SP = new SoundPlayer(Game.Properties.Resources.Song);
        public string bölüm;
        public string WinTekrar;
        private void button1_Click(object sender, EventArgs e)
        {
        }
        public enum level {Level1,Level2,Level3,Level4,Level5,Level6,Level7,Level8,Level9,Level10}

        int puan = 0;
        int sayı = 0;
        public int kalan;
        string durum;

        private void yenidenBtn(bool yeniden)
        {
            TekrarButon.Visible = yeniden;
        }

        Action callOnlyOnce(Action action)
        {
            var context = new ContextCallOnlyOnce();
            Action ret = () => {
                if (false == context.AlreadyCalled)
                {
                    action();
                    context.AlreadyCalled = true;
                }
            };

            return ret;
        }
        class ContextCallOnlyOnce
        {
            public bool AlreadyCalled;
        }
        private void RaundTime_Tick(object sender, EventArgs e)
        {
           

                if (CircleButton.Value == 100)
                {
                    CircleButton.Value = 0;
                    RaundTime.Stop();
                }
                else
                {
                    sayı++;
                    RaundTime.Start();

                    if (level.Level1.ToString() == label2.Text)
                    {
                        RaundTime.Start();


                        try
                        {
                            RaundTime.Start();
                            RaundTime.Interval = 40;
                            label1.Text = sayı.ToString();
                            CircleButton.Value = sayı;

                        }
                        catch (Exception)
                        {

                        }


                    }
                    else if (level.Level2.ToString() == label2.Text)
                    {
                        RaundTime.Interval = 30;
                        label1.Text = sayı.ToString();
                        CircleButton.Value = sayı;
                    }
                    else if (level.Level3.ToString() == label2.Text)
                    {
                        RaundTime.Interval = 20;
                        label1.Text = sayı.ToString();
                        CircleButton.Value = sayı;
                    }
                    else if (level.Level4.ToString() == label2.Text)
                    {
                        RaundTime.Interval = 15;
                        label1.Text = sayı.ToString();
                        CircleButton.Value = sayı;
                    }

                    else if (level.Level5.ToString() == label2.Text)
                    {
                        RaundTime.Interval = 10;
                        label1.Text = sayı.ToString();
                        CircleButton.Value = sayı;
                    }
                    else if (level.Level6.ToString() == label2.Text)
                    {
                        RaundTime.Interval = 8;
                        label1.Text = sayı.ToString();
                        CircleButton.Value = sayı;
                    }
                    else if (level.Level7.ToString() == label2.Text)
                    {
                        RaundTime.Interval = 6;
                        label1.Text = sayı.ToString();
                        CircleButton.Value = sayı;
                    }

                    else if (level.Level8.ToString() == label2.Text)
                    {
                        RaundTime.Interval = 3;
                        label1.Text = sayı.ToString();
                        CircleButton.Value = sayı;
                    }
                    else if (level.Level9.ToString() == label2.Text)
                    {
                        RaundTime.Interval = 2;
                        label1.Text = sayı.ToString();
                        CircleButton.Value = sayı;
                    }
                    else if (level.Level10.ToString() == label2.Text)
                    {
                        RaundTime.Interval = 1;
                        label1.Text = sayı.ToString();
                        CircleButton.Value = sayı;
                    if (kalan == 0 || kalan < 0)
                    {
                        CircleButton.Value = 0;
                        RaundTime.Stop();
                    }
                    }
                }

                if (CircleButton.Value == 99)
                {
                    pictureBox2.Visible = true;

                    durum = "kaybettin";
                    yenidenBtn(true);
                    TekrarDesignTimer.Start();
                    FinalSkorLabel.Visible = true;
                    FinalSkorLabelSonuc.Visible = true;
                    FinalSkorLabel.BringToFront();
                    FinalSkorLabelSonuc.BringToFront();
                    FinalSkorLabelSonuc.Text = puan.ToString();
                }

            
        }
        WinnerForm wf = new WinnerForm();
         public void Form1_Load(object sender, EventArgs e)
         {

            /* AnaMenuBtn.Image = Properties.Resources.AnasayfaResim;
             AnaMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;*/
            pictureBox1.Image = Properties.Resources.ProfilPic;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            DurVeDevamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DurVeDevamBtn.Image = Properties.Resources.DurdurResim;
           pictureBox2.Image = Properties.Resources.OyunBittiPic;
           pictureBox2.BackgroundImageLayout = ImageLayout.Tile;
            SP.Play();
            RaundTime.Start();
            kalan = 10;
            label4.Text= kalan.ToString();
            Point pt = new Point(700, 290);
         
            /*CircleButton.BringToFront();
            TekrarButon.BringToFront();
            pictureBox2.BringToFront();*/
           
         }


        private void PuanHesapla()
        {            
            puan += (100 - Convert.ToInt32(label1.Text));
            PuanLabel.Text = puan.ToString();
        }


        bool durdur = true;
        private void DurVeDevamBtn_Click(object sender, EventArgs e)
        {
          if(label2.Text == level.Level10.ToString() && kalan ==0)
                MessageBox.Show("Oyun Bitti Ve Siz Kazandınız. \n Oyunu Tekrar Oynamak İçin Yukardaki Butona Tıklamayı Dene ;)!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
          else
            {
                if (durum == "kaybettin" && durdur == true)
                {
                    MessageBox.Show("Biten Oyun Maalesef Durmaz Bazgan!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (durdur == true)
                    {
                        CircleButton.ProgressColor = Color.Red;
                        DurVeDevamBtn.Text = "Devam Et";
                        RaundTime.Stop();
                        durdur = false;
                        SP.Stop();
                        DurVeDevamBtn.ImageAlign = ContentAlignment.MiddleLeft;
                        DurVeDevamBtn.Image = Properties.Resources.BaslatResim;

                    }
                    else if (durdur == false)
                    {
                        CircleButton.ProgressColor = Color.SpringGreen;
                        DurVeDevamBtn.Text = "    Oyunu Durdur";
                        RaundTime.Start();
                        durdur = true;
                        SP.PlayLooping();
                        DurVeDevamBtn.ImageAlign = ContentAlignment.MiddleLeft;
                        DurVeDevamBtn.Image = Properties.Resources.DurdurResim;
                    }
                }
            }

            
           
        }


        public void CircleButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (bölüm == "degisken")
            {
                if (durdur)
                {
                    if (durum == "kaybettin")
                    {
                        kalan = 10;
                    }


                    else if (durum != "kaybettin")
                    {
                        //  Sp.Play();
                        if (level.Level1.ToString() == label2.Text)
                        {
                            PuanHesapla();
                            CircleButton.Height = 300;
                            CircleButton.Width = 300;
                            RaundTime.Start();

                            Random x = new Random();

                            Point pt = new Point(

                            int.Parse(x.Next(1050).ToString()),
                            int.Parse(x.Next(550).ToString())
                         );
                            System.Threading.Thread.Sleep(50);
                            CircleButton.Location = pt;
                            CircleButton.Left += 50;

                            sayı = 0;
                            kalan--;

                            label4.Text = kalan.ToString();


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 2 ");
                                RaundTime.Start();
                                Point xx = new Point(510, 159);
                                CircleButton.Location = xx;
                                label2.Text = level.Level2.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level2.ToString() == label2.Text)
                        {
                            CircleButton.Height = 250;
                            CircleButton.Width = 250;
                            RaundTime.Start();

                            Random x = new Random();

                            Point pt = new Point(
                                int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(500).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;

                            PuanHesapla();

                            kalan--;
                            label4.Text = kalan.ToString();


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 3  ");
                                RaundTime.Start();
                                label2.Text = level.Level3.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }

                            sayı = 0;
                        }

                        else if (level.Level3.ToString() == label2.Text)
                        {
                            CircleButton.Height = 200;
                            CircleButton.Width = 200;
                            RaundTime.Start();
                            Random x = new Random();

                            Point pt = new Point(
                                 int.Parse(x.Next(1050).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;



                            PuanHesapla();
                            sayı = 0;
                            kalan--;

                            label4.Text = kalan.ToString();


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 4  ");
                                RaundTime.Start();
                                label2.Text = level.Level4.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level4.ToString() == label2.Text)
                        {
                            CircleButton.Height = 150;
                            CircleButton.Width = 150;
                            RaundTime.Start();

                            Random x = new Random();

                            Point pt = new Point(
                                int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;


                            PuanHesapla();
                            sayı = 0;
                            kalan--;

                            label4.Text = kalan.ToString();

                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 5  ");
                                RaundTime.Start();
                                label2.Text = level.Level5.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level5.ToString() == label2.Text)
                        {
                            RaundTime.Start();
                            CircleButton.Height = 100;
                            CircleButton.Width = 100;
                            PuanHesapla();
                            sayı = 0;
                            kalan--;
                            label4.Text = kalan.ToString();
                            Random x = new Random();

                            Point pt = new Point(
                               int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 6 ");
                                RaundTime.Start();
                                label2.Text = level.Level6.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level6.ToString() == label2.Text)
                        {
                            RaundTime.Start();
                            CircleButton.Height = 50;
                            CircleButton.Width = 50;
                            PuanHesapla();
                            sayı = 0;
                            kalan--;
                            label4.Text = kalan.ToString();
                            Random x = new Random();

                            Point pt = new Point(
                                int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 7  ");
                                RaundTime.Start();
                                label2.Text = level.Level7.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level7.ToString() == label2.Text)
                        {
                            RaundTime.Start();
                            CircleButton.Height = 35;
                            CircleButton.Width = 35;
                            PuanHesapla();
                            sayı = 0;
                            kalan--;
                            label4.Text = kalan.ToString();
                            Random x = new Random();

                            Point pt = new Point(
                               int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 8");
                                RaundTime.Start();
                                label2.Text = level.Level8.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }
                        else if (level.Level8.ToString() == label2.Text)
                        {
                            RaundTime.Start();
                            CircleButton.Height = 30;
                            CircleButton.Width = 30;
                            PuanHesapla();
                            sayı = 0;
                            kalan--;
                            label4.Text = kalan.ToString();
                            Random x = new Random();

                            Point pt = new Point(
                                int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 9");
                                RaundTime.Start();
                                label2.Text = level.Level9.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level9.ToString() == label2.Text)
                        {
                            RaundTime.Start();
                            CircleButton.Height = 30;
                            CircleButton.Width = 30;
                            PuanHesapla();
                            sayı = 0;
                            kalan--;
                            label4.Text = kalan.ToString();
                            Random x = new Random();

                            Point pt = new Point(
                                int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 10");
                                RaundTime.Start();
                                label2.Text = level.Level10.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString(); 
                            }
                        }

                        else if (level.Level10.ToString() == label2.Text)
                        {
                    
                            RaundTime.Start();
                            CircleButton.Height = 30;
                            CircleButton.Width = 30;
                            PuanHesapla();
                            sayı = 0;
                            kalan--;
                            label4.Text = kalan.ToString();
                            Random x = new Random();

                            Point pt = new Point(
                                int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;

                            if (kalan == 0 || kalan < 0)
                            {
                                kalan = 0;
                                pictureBox3.Image = Properties.Resources.KupaPic;
                                pictureBox3.BackgroundImageLayout = ImageLayout.Center;
                                WinPanel.Visible = true;
                                FinalSkorLabel.Visible = true;
                                FinalSkorLabelSonuc.Visible = true;
                                FinalSkorLabel.BringToFront();
                                FinalSkorLabelSonuc.BringToFront();
                                FinalSkorLabelSonuc.Text = puan.ToString();
                               
                            }


                        }
                    }
                }
                else
                {
                    //MessageBox.Show("Oyun Duraklatıldı! \n Devam Etmek için 'Devam Et' Butonuna Tıkla");
                }
            }
            else if(bölüm=="sabit")
            {
                CircleButton.Height = 225;
                CircleButton.Width = 225;
                if (durdur)
                {
                    if (durum == "kaybettin")
                    {
                        kalan = 10;
                    }
                

                    else if (durum != "kaybettin")
                    {
                    
                        //  Sp.Play();
                        if (level.Level1.ToString() == label2.Text)
                        {
                            PuanHesapla();
                            RaundTime.Start();

                            Random x = new Random();

                            Point pt = new Point(

                            int.Parse(x.Next(1050).ToString()),
                            int.Parse(x.Next(550).ToString())
                         );
                            System.Threading.Thread.Sleep(50);
                            CircleButton.Location = pt;
                            CircleButton.Left += 50;

                            sayı = 0;
                            kalan--;

                            label4.Text = kalan.ToString();


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 2 ");
                                RaundTime.Start();

                                Point xx = new Point(510, 159);
                                CircleButton.Location = xx;
                                label2.Text = level.Level2.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level2.ToString() == label2.Text)
                        {

                            RaundTime.Start();

                            Random x = new Random();

                            Point pt = new Point(
                                int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(500).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;

                            PuanHesapla();

                            kalan--;
                            label4.Text = kalan.ToString();


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 3  ");
                                RaundTime.Start();
                                label2.Text = level.Level3.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }

                            sayı = 0;
                        }

                        else if (level.Level3.ToString() == label2.Text)
                        {

                            RaundTime.Start();
                            Random x = new Random();

                            Point pt = new Point(
                                 int.Parse(x.Next(1050).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;



                            PuanHesapla();
                            sayı = 0;
                            kalan--;

                            label4.Text = kalan.ToString();


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 4  ");
                                RaundTime.Start();
                                label2.Text = level.Level4.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level4.ToString() == label2.Text)
                        {

                            RaundTime.Start();

                            Random x = new Random();

                            Point pt = new Point(
                                int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;


                            PuanHesapla();
                            sayı = 0;
                            kalan--;

                            label4.Text = kalan.ToString();

                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 5  ");
                                RaundTime.Start();
                                label2.Text = level.Level5.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level5.ToString() == label2.Text)
                        {
                            RaundTime.Start();

                            PuanHesapla();
                            sayı = 0;
                            kalan--;
                            label4.Text = kalan.ToString();
                            Random x = new Random();

                            Point pt = new Point(
                               int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 6 ");
                                RaundTime.Start();
                                label2.Text = level.Level6.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level6.ToString() == label2.Text)
                        {
                            RaundTime.Start();

                            PuanHesapla();
                            sayı = 0;
                            kalan--;
                            label4.Text = kalan.ToString();
                            Random x = new Random();

                            Point pt = new Point(
                                int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 7  ");
                                RaundTime.Start();
                                label2.Text = level.Level7.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level7.ToString() == label2.Text)
                        {
                            RaundTime.Start();

                            PuanHesapla();
                            sayı = 0;
                            kalan--;
                            label4.Text = kalan.ToString();
                            Random x = new Random();

                            Point pt = new Point(
                               int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 8");
                                RaundTime.Start();
                                label2.Text = level.Level8.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }
                        else if (level.Level8.ToString() == label2.Text)
                        {
                            RaundTime.Start();

                            PuanHesapla();
                            sayı = 0;
                            kalan--;
                            label4.Text = kalan.ToString();
                            Random x = new Random();

                            Point pt = new Point(
                                int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 9");
                                RaundTime.Start();
                                label2.Text = level.Level9.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level9.ToString() == label2.Text)
                        {
                            RaundTime.Start();

                            PuanHesapla();
                            sayı = 0;
                            kalan--;
                            label4.Text = kalan.ToString();
                            Random x = new Random();

                            Point pt = new Point(
                                int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;


                            if (kalan == 0)
                            {
                                RaundTime.Stop();
                                MessageBox.Show("Tebrikler! Level 10");
                                RaundTime.Start();
                                label2.Text = level.Level10.ToString();
                                kalan = 20;
                                label4.Text = kalan.ToString();
                            }
                        }

                        else if (level.Level10.ToString() == label2.Text && kalan >0)
                        {
                            RaundTime.Start();

                            PuanHesapla();
                            sayı = 0;
                            kalan--;
                            label4.Text = kalan.ToString();
                            Random x = new Random();

                            Point pt = new Point(
                                int.Parse(x.Next(1000).ToString()),
                                int.Parse(x.Next(600).ToString())
                                );
                            System.Threading.Thread.Sleep(50);

                            CircleButton.Location = pt;
                            CircleButton.Left += 50;

                          
                            if (kalan == 0 || kalan<0)
                            {
                                kalan = 0;
                                pictureBox3.Image = Properties.Resources.KupaPic;
                                pictureBox3.BackgroundImageLayout = ImageLayout.Center;
                                WinPanel.Visible = true;
                                FinalSkorLabel.Visible = true;
                                FinalSkorLabelSonuc.Visible = true;
                                FinalSkorLabel.BringToFront();
                                FinalSkorLabelSonuc.BringToFront();
                                FinalSkorLabelSonuc.Text = puan.ToString();
                               
                            }
                        }
                    }
                }
                else
                {
               //     MessageBox.Show("Oyun Duraklatıldı! \n Devam Etmek için 'Devam Et' Butonuna Tıkla");
                }
            }
        }


        private void TekrarButon_Click(object sender, EventArgs e)
        {
            kalan = 10;     
          
            FinalSkorLabel.Visible = false;
            FinalSkorLabelSonuc.Visible = false;
            try
            {
                if (durum == "kaybettin")
                {
               
                    FinalSkorLabelSonuc.Text = PuanLabel.Text;
                        PuanHesapla();
                       
                        RaundTime.Start();

                        Random x = new Random();

                        Point pt = new Point(
                            int.Parse(x.Next(1000).ToString()),
                            int.Parse(x.Next(500).ToString())
                     );
                        CircleButton.Location = pt;
                        CircleButton.Left += 50;

                        sayı = 0;
                        kalan--;
                        label4.Text = kalan.ToString();
 
                    CircleButton.Value = 0;
                    pictureBox2.Visible = false;
                    pictureBox1.Refresh();
                    durum = level.Level1.ToString();
                    puan = 0;
                    PuanLabel.Text = puan.ToString();
                    CircleButton.Refresh();
                    label4.Text = 10.ToString();
                    label2.Text = level.Level1.ToString();
                    yenidenBtn(false);
                  

                }
             }
            catch (Exception)
            {
                throw;
            }
        }

       

        private void button2_Paint(object sender, PaintEventArgs e)
        {
         /*   e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(-90);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen obj_pen = new Pen(Color.Red);
            Rectangle rect1 = new Rectangle(0 - this.Width / 2+20,0-this.Height, this.Width-40,this.Height-40);*/
          
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CircleButton_Paint(object sender, PaintEventArgs e)
        {
           /* e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(-90);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen obj_pen = new Pen(Color.Red);
            Rectangle rect1 = new Rectangle(0 - this.Width / 2 + 20, 0 - this.Height, this.Width - 40, this.Height - 40);*/
        }
        protected override CreateParams CreateParams => base.CreateParams;

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        private void AnaMenuBtn_Click(object sender, EventArgs e)
        {
            if (DurVeDevamBtn.Text == "Devam Et")
            {
                RaundTime.Stop();
                DialogResult Cevap = MessageBox.Show("Anasayfa'ya Dönmek İstiyor Musun?", "Anasayfa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Cevap == DialogResult.Yes)
                {
                    AnaMenu Anamenu = new AnaMenu();
                    Anamenu.Show();
                    this.Hide();
                    SP.Stop();
                }             
            }
            else
            {
                RaundTime.Stop();
                DialogResult Cevap = MessageBox.Show("Anasayfa'ya Dönmek İstiyor Musun?", "Anasayfa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Cevap == DialogResult.Yes)
                {
                    AnaMenu Anamenu = new AnaMenu();
                    Anamenu.Show();
                    this.Hide();
                    SP.Stop();
                }
                else if (Cevap == DialogResult.No)
                {
                    if(durum!="kaybettin")
                    RaundTime.Start();

                }
            }
        }
        int xax = 0;
        private void TekrarDesignTimer_Tick(object sender, EventArgs e)
        {
            xax++;
            if(xax<5000)
            {
                if(xax%2==0)
                {
                    TekrarButon.BackColor = Color.Black;
                    TekrarButon.ForeColor = Color.White;
                }
                else if(xax%2==1)
                {
                    TekrarButon.BackColor = Color.White;
                    TekrarButon.ForeColor = Color.Black;

                }
            }

        }

        private void SabitBbuton_Click(object sender, EventArgs e)
        {

        }

        private void SabitBbuton_Click_1(object sender, EventArgs e)
        {
            SP.Stop();
            WinPanel.Visible = false;
            FinalSkorLabel.Visible = false;
            FinalSkorLabelSonuc.Visible = false;
            label2.Text = level.Level1.ToString();
            kalan = 10;
            puan = 0;
            PuanLabel.Text = puan.ToString();
            label4.Text = kalan.ToString();
            Point pt = new Point(700, 290);
            SP.Play();
            RaundTime.Start();
        }
    }
}
