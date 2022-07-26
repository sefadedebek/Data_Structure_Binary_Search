using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structure_Binary_Search
{
    public partial class Form1 : Form
    {
        int baslangic, bitis, orta, arananSayi;
        public int BinarySearch(int arananSayi, int[] sayilar)
        {
            orta = baslangic + bitis / 2;
            if (baslangic <= bitis)
            {
                orta = (baslangic + bitis) / 2;
                switch (orta)
                {
                    case 0:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, label21.Location.Y);
                        break;
                    case 1:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, label20.Location.Y);
                        break;
                    case 2:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, label19.Location.Y);
                        break;
                    case 3:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, label18.Location.Y);
                        break;
                    case 4:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, label17.Location.Y);
                        break;
                    case 5:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, label16.Location.Y);
                        break;
                    case 6:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, label15.Location.Y);
                        break;
                    case 7:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, label14.Location.Y);
                        break;
                    case 8:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, label13.Location.Y);
                        break;
                    case 9:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, label12.Location.Y);
                        break;
                    case 10:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, label11.Location.Y);
                        break;
                }
                if (sayilar[orta] > arananSayi)
                {
                    bitis = orta - 1;
                }
                else if (sayilar[orta] < arananSayi)
                {
                    baslangic = orta + 1;
                }
                else
                {
                    label24.Text = "Sayı Bulundu!";
                    return orta;
                }
            }
            else
            {
                label24.Text = "Sayı Bulunamadı!";
            }

            return -1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BinarySearch(arananSayi,sayilar);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baslangic = 0;
            bitis = sayilar.Length - 1;
        }

        private void MaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            arananSayi = Convert.ToInt32(maskedTextBox1.Text);
        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        int[] sayilar = {13, 25, 36, 48, 58, 61, 73, 79, 81, 93, 98};

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
         
        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }
    }
}
