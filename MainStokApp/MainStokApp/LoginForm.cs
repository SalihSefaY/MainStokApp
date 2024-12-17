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
    public partial class LoginForm : Form

    {
             
            

            public LoginForm()
            {
                InitializeComponent();
            }

            
            private void LoginForm_Load(object sender, EventArgs e)
            {

            }


        private void button2_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifreyi textBox'lardan alıyoruz
            string kullaniciAdi = textBox3.Text;
            string sifre = textBox4.Text;
            string rol = ""; // Rol değişkeni başta boş olarak tanımlanıyor

            
            for (int i = 0; i < kullaniciAdi.GetLength(0); i++)
            {
                if (kullaniciAdi == kullaniciAdi[i, 0] && sifre == kullaniciAdi[i, 1])
                {
                    rol = kullaniciAdi[i, 2]; // Doğru kullanıcı bulundu, rol atanıyor
                    break; // Döngüyü sonlandır
                }
            }

            
            if (!string.IsNullOrEmpty(rol))
            {
                MessageBox.Show($"Giriş Başarılı! Rol: {rol}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                Form1 form1 = new Form1(rol);
                this.Hide(); // Bu formu gizle
                Form1.ShowDialog(); // Yeni formu göster
                this.Show(); // Yeni form kapandığında bu form tekrar gösterilir
            }
            else
            {
                
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}
