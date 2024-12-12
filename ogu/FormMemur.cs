using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ogu
{
    public partial class FormMemur : Form
    {
        public FormMemur()
        {
            InitializeComponent();
        }

        // Bağlantı dizesi
        string connectionString = @"Server=localhost; Database=ogu; Integrated Security=True;";

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            // Form1'i göster
            Form1 form1 = new Form1();
            form1.Show();

            // FormMemur'u gizle
            this.Hide();
        }

        private void FormMemur_Load(object sender, EventArgs e)
        {
            // Verilerin sıralanması için sorguyu güncelleme
            string sqlQuery = "SELECT * FROM Ogrenciler ORDER BY OgrenciNumarasi";  // Burada 'OgrenciNumarasi' ile sıralama yapılıyor

            // Bağlantıyı açın
            using (SqlConnection connection = new SqlConnection(connectionString))  
            {
                connection.Open();

                // DataAdapter ile veriyi al ve DataGridView'e yükle
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // DataGridView'ı verilerle doldur
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
    }
}
