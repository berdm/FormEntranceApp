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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(rdCircle.Checked == true)
            {
                Circle circle = new Circle();
                double result = circle.getArea(Convert.ToDouble(txtRadius.Text));
                MessageBox.Show("Dairenin Alanı:" + result.ToString(), "Alan Hesaplama Sonucu",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);

                /*
                *Buton turleri: OK, YESNO,OKCancel, RetryCancel, YesNoCancel,AbortRetryIgnore
                *Uyarı turleri: Information ,Error,Question,Wrning ,Stop,Exclanation
                */

            }

            if(rdCylinder.Checked == true)
            {
                Cylinder cylinder = new Cylinder();
                double h = Convert.ToDouble(txtHeight.Text);
                cylinder.h = h;
                double result = cylinder.getArea(Convert.ToDouble(txtRadius.Text));
                MessageBox.Show("Silindirin Alanı:" + result.ToString());
            }


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = frmEntrance.user_name;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmEntrance entrance = new frmEntrance();
            entrance.Show();
        }

        private void rdCircle_MouseClick(object sender, MouseEventArgs e)
        {
            txtHeight.Visible = false;
            label2.Visible = false;
            txtHeight.Clear();
            txtRadius.Clear();
        }

        private void rdCylinder_MouseClick(object sender, MouseEventArgs e)
        {
            txtHeight.Visible = true;
            label2.Visible = true;
            txtRadius.Clear();
            txtHeight.Clear();
        }
    }
}
