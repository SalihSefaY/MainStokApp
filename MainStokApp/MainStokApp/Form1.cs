using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainStokApp
{

    public partial class Form1 : Form
    {
        private string rol;

        public Form1(string rol) // Parametreli constructor
        {
            InitializeComponent();
            this.rol = rol;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.SizeGripStyle = SizeGripStyle.Hide;

            if (rol=="Yönetici")
            {
                CalisanY.Visible = true;
                RaporlarY.Visible = true;
            }
            else
            {
                CalisanY.Visible = false;
                RaporlarY.Visible = false;
            }
            

            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm Lform = new LoginForm();
            Lform.Show();
        }
    }
}