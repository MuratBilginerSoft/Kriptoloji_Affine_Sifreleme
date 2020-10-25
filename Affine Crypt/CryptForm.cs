using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Affine_Crypt
{
    public partial class CryptForm : Form
    {
        string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        int a, b, m, k;
        string metin, şifreliMetin;
        string z;

        public CryptForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            m = int.Parse(textBox3.Text);

            if (a%m != 0)
            {
                metin = richTextBox1.Text.ToUpper();
                şifreliMetin = "";


                for (int i = 0; i < metin.Length; i++)
                {
                    if (alfabe.IndexOf(metin[i]) == -1) 
                    {
                        şifreliMetin += metin[i].ToString();
                    }

                    else
                    {

                        k = alfabe.IndexOf(metin[i]);
                        z = alfabe[((k * a + b) % m)].ToString();

                        şifreliMetin += z;

                    }
                   
                }

                richTextBox2.Text = şifreliMetin;
            }

            else
            {
                MessageBox.Show("a ve m Değerleri Birbirine Tam Bölünememelidir.");
            }
           

        }
    }
}
