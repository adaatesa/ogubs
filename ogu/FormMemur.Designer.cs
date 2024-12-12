namespace ogu
{
    partial class FormMemur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogubsDataSet = new ogu.ogubsDataSet();
            this.oguDataSet = new ogu.oguDataSet();
            this.oguDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrencilerTableAdapter = new ogu.ogubsDataSetTableAdapters.OgrencilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oguDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oguDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGeriDon
            // 
            this.buttonGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGeriDon.Location = new System.Drawing.Point(26, 24);
            this.buttonGeriDon.Name = "buttonGeriDon";
            this.buttonGeriDon.Size = new System.Drawing.Size(75, 23);
            this.buttonGeriDon.TabIndex = 0;
            this.buttonGeriDon.Text = "Geri";
            this.buttonGeriDon.UseVisualStyleBackColor = true;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeriDon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ad,
            this.soyad,
            this.numara});
            this.dataGridView1.DataSource = this.oguDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(135, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 191);
            this.dataGridView1.TabIndex = 1;
            // 
            // ad
            // 
            this.ad.HeaderText = "Ad";
            this.ad.Name = "ad";
            // 
            // soyad
            // 
            this.soyad.HeaderText = "Soyad";
            this.soyad.Name = "soyad";
            // 
            // numara
            // 
            this.numara.HeaderText = "Numara";
            this.numara.Name = "numara";
            // 
            // ogrencilerBindingSource
            // 
            this.ogrencilerBindingSource.DataMember = "Ogrenciler";
            this.ogrencilerBindingSource.DataSource = this.ogubsDataSet;
            // 
            // ogubsDataSet
            // 
            this.ogubsDataSet.DataSetName = "ogubsDataSet";
            this.ogubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oguDataSet
            // 
            this.oguDataSet.DataSetName = "oguDataSet";
            this.oguDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oguDataSetBindingSource
            // 
            this.oguDataSetBindingSource.DataSource = this.oguDataSet;
            this.oguDataSetBindingSource.Position = 0;
            // 
            // ogrencilerTableAdapter
            // 
            this.ogrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // FormMemur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGeriDon);
            this.Name = "FormMemur";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormMemur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oguDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oguDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGeriDon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn numara;
        private System.Windows.Forms.BindingSource oguDataSetBindingSource;
        private oguDataSet oguDataSet;
        private ogubsDataSet ogubsDataSet;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource;
        private ogubsDataSetTableAdapters.OgrencilerTableAdapter ogrencilerTableAdapter;
    }
}