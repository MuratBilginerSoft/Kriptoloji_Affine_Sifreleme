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
    public partial class DecryptForm : Form
    {
        string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        int a, b, m, k, z, g;
        string metin, şifreliMetin;
        string y;

        public DecryptForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            m = int.Parse(textBox3.Text);

            if (a % m != 0)
            {
                şifreliMetin = richTextBox1.Text.ToUpper();
                metin = "";

                for (int i = 0; ; i++)
                {
                    g = (a * i) % 29;

                    if (g == 1)
                    {
                        z = i;
                        break;
                    }
                }

                for (int i = 0; i < şifreliMetin.Length; i++)
                {
                    if (alfabe.IndexOf(şifreliMetin[i]) == -1)
                    {
                        metin += şifreliMetin[i].ToString();
                    }

                    else
                    {

                        k = alfabe.IndexOf(şifreliMetin[i]);
                        y = alfabe[Math.Abs(((z*(k-b)) % m))].ToString();

                        metin += y;

                    }

                }

                richTextBox2.Text = metin;
            }

            else
            {
                MessageBox.Show("a ve m Değerleri Birbirine Tam Bölünememelidir.");
            }

        }
    }
}
