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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void BtnCrypt_Click(object sender, EventArgs e)
        {
            CryptForm CF = new CryptForm();
            this.Hide();
            CF.ShowDialog();
            this.Show();
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            DecryptForm DCF = new DecryptForm();
            this.Hide();
            DCF.ShowDialog();
            this.Show();
        }
    }
}
