using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogu
{
    public partial class FormOgretmen : Form
    {
        public FormOgretmen()
        {
            InitializeComponent();
        }

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            // Form1'i göster
            Form1 form1 = new Form1();
            form1.Show();

            // FormOgretmen'i kapat
            this.Close(); 
        }
    }
}
