using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void goToUserCreationFormButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void testUserButton_Click(object sender, EventArgs e)
        {
            bool isKullaniciAdiCorrect = false;
            bool isParolaCorrect = false;

            int kullanıcıAdıLineFound = 0;
            int parolaLineFound = 0;

            string kullaniciAdi = kullaniciAdiTextBox.Text;
            string parola = parolaTextBox.Text;

            for (int i = 0; i < Form1.userIndex; i++)
            {
                if (kullaniciAdi == Form1.kullaniciAdlari[i])
                {
                    kullanıcıAdıLineFound = i;
                    isKullaniciAdiCorrect=true;
                    break;
                }
            }
            for (int i = 0; i < Form1.userIndex; i++)
            {
                if (parola == Form1.parolalar[i])
                {
                    parolaLineFound = i;
                    isParolaCorrect=true;
                    break;
                }
                if (isKullaniciAdiCorrect && isParolaCorrect)
                {
                    if (kullanıcıAdıLineFound == parolaLineFound)
                    {
                        richTextBox1.Text = "Kullanıcı sistemde tanımlıdır";
                        MessageBox.Show("Kullanıcı sistemde tanımlıdır");
                    }
                    else
                    {
                        richTextBox1.Text = "Kullanıcı sistemde tanımlı değildir!";
                        MessageBox.Show("Kullanıcı sistemde tanımlı değildir!");
                    }
                }
            }    
        }

    }
}