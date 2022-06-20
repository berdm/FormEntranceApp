using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_16122020
{
    public partial class frmEntrance : Form
    {
        public frmEntrance()
        {
            InitializeComponent();
        }
        public static string user_name;

        private void frmEntrance_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrance_Click(object sender, EventArgs e)
        {
            string password;
            user_name = txtUsername.Text;
            password = txtPassword.Text;

            if((user_name=="balfati" && password=="2828") || (user_name == "fatihbal" && password == "3939"))
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı dı veya şifreyi hatalı girdiniz. Tekrar deneyiniz.",
                    "Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
