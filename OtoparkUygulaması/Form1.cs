using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGiriş_Click(object sender, EventArgs e)
        {
            giristxt1.Text = "admin";
            giristxt2.Text = "123456";

            if (giristxt1.Text == "admin" && giristxt2.Text == "123456")
            {
                OtoParkGirişÇıkış fr = new OtoParkGirişÇıkış();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yapdınız");
            }
        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tolgahan Muhcı", "Bilgilendirme Mesajıdır", MessageBoxButtons.OK);

        }
    }
}
