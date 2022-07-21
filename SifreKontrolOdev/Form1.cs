using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreKontrolOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sifre = "";
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            sifre = txtSifre.Text;
            if (sifre == "")
            {
                
                lblPower.ForeColor = Color.Black;
                lblPower.BackColor = Color.White;
                txtSifre.BackColor = Color.White;
                lblPower.Text = "Şifrenizi Giriniz";
            }
            else if (sifre.Length < 8)
            {
                lblPower.BackColor = Color.Red;
                txtSifre.BackColor = Color.Red;
                lblPower.Text = "Zayıf";
                lblPower.ForeColor = Color.White;
                txtSifre.ForeColor = Color.White;


            }
            else if (sifre.Length >= 8)
            {
                if (sifre.All(Char.IsDigit) || sifre.All(Char.IsLetter) || !sifre.Any(Char.IsLetterOrDigit))
                {
                    lblPower.BackColor = Color.Red;
                    lblPower.Text = "Zayıf";
                    txtSifre.BackColor = Color.Red;
                    lblPower.ForeColor = Color.White;
                    txtSifre.ForeColor = Color.White;


                }
                else if (sifre.Any(Char.IsDigit) && sifre.Any(Char.IsLetter) && !sifre.All(Char.IsLetterOrDigit) && sifre.Any(Char.IsUpper))
                {
                    lblPower.BackColor = Color.Green;
                    lblPower.Text = "Güçlü";
                    txtSifre.BackColor = Color.Green;
                    lblPower.ForeColor = Color.White;
                    txtSifre.ForeColor = Color.White;


                }

                else
                {
                    lblPower.BackColor = Color.Blue;
                    lblPower.Text = "Orta";
                    txtSifre.BackColor = Color.Blue;
                    lblPower.ForeColor = Color.White;
                    txtSifre.ForeColor = Color.White;
                }
            }
        }
    }
}
