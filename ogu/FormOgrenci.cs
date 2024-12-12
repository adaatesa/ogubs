using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ogu
{
    public partial class FormOgrenci : Form
    {
        private string connectionString = "Server=localhost.cha;Database=cha;Trusted_Connection=True;";

        public FormOgrenci()
        {
            InitializeComponent();
        }

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            // Form1'i göster
            Form1 form1 = new Form1(); 
            form1.Show();

            // FormOgrenci'yi gizle veya kapat
            this.Close(); // Bu formu tamamen kapatır
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Formdaki alanlardan veri al
            string ad = textBox1.Text.Trim(); // Ad için TextBox
            string soyad = textBox2.Text.Trim(); // Soyad için TextBox
            string ogrenciNumarasi = textBox3.Text.Trim(); // Öğrenci Numarası için TextBox

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(ogrenciNumarasi))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // SQL bağlantısı ve veri ekleme işlemi
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conn.Open(); // Bağlantıyı aç
                    string query = "INSERT INTO Ogrenciler (Ad, Soyad, OgrenciNumarasi) VALUES (@Ad, @Soyad, @OgrenciNumarasi)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Soyad", soyad);
                        cmd.Parameters.AddWithValue("@OgrenciNumarasi", ogrenciNumarasi);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Komutu çalıştır
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt başarılı!");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt başarısız.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
