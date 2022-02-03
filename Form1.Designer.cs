
namespace WindowsFormsApp3
{
    partial class form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.btnDodaj = new System.Windows.Forms.Button();
            this.textNumerFaktury = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textCena = new System.Windows.Forms.TextBox();
            this.cbKontrahent = new System.Windows.Forms.ComboBox();
            this.lblNumerfaktury = new System.Windows.Forms.Label();
            this.lblDatawystawienia = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerfakturyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datawystawieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontrahentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test34567BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESTDataSet = new WindowsFormsApp3.TESTDataSet();
            this.test34567TableAdapter = new WindowsFormsApp3.TESTDataSetTableAdapters.test34567TableAdapter();
            this.testDataSet1 = new WindowsFormsApp3.TESTDataSet();
            this.btnWydrukuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnAktualizujdane = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnEdytujdane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test34567BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(501, 28);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(116, 63);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj Fakturę ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNumerFaktury
            // 
            this.textNumerFaktury.Location = new System.Drawing.Point(168, 52);
            this.textNumerFaktury.Name = "textNumerFaktury";
            this.textNumerFaktury.Size = new System.Drawing.Size(133, 22);
            this.textNumerFaktury.TabIndex = 1;
           
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textCena
            // 
            this.textCena.Location = new System.Drawing.Point(168, 139);
            this.textCena.Name = "textCena";
            this.textCena.Size = new System.Drawing.Size(133, 22);
            this.textCena.TabIndex = 4;
            // 
            // cbKontrahent
            // 
            this.cbKontrahent.FormattingEnabled = true;
            this.cbKontrahent.Items.AddRange(new object[] {
            "IKEA",
            "KFC",
            "Microsoft"});
            this.cbKontrahent.Location = new System.Drawing.Point(168, 184);
            this.cbKontrahent.Name = "cbKontrahent";
            this.cbKontrahent.Size = new System.Drawing.Size(121, 24);
            this.cbKontrahent.TabIndex = 5;
            // 
            // lblNumerfaktury
            // 
            this.lblNumerfaktury.AutoSize = true;
            this.lblNumerfaktury.Location = new System.Drawing.Point(42, 52);
            this.lblNumerfaktury.Name = "lblNumerfaktury";
            this.lblNumerfaktury.Size = new System.Drawing.Size(97, 17);
            this.lblNumerfaktury.TabIndex = 6;
            this.lblNumerfaktury.Text = "Numer faktury";
            // 
            // lblDatawystawienia
            // 
            this.lblDatawystawienia.AutoSize = true;
            this.lblDatawystawienia.Location = new System.Drawing.Point(42, 98);
            this.lblDatawystawienia.Name = "lblDatawystawienia";
            this.lblDatawystawienia.Size = new System.Drawing.Size(120, 17);
            this.lblDatawystawienia.TabIndex = 7;
            this.lblDatawystawienia.Text = "Data wystawienia ";
            // 
            // lblCena
            // 
            this.lblCena.Location = new System.Drawing.Point(42, 142);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(97, 17);
            this.lblCena.TabIndex = 8;
            this.lblCena.Text = "Cena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kontrahent";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.numerfakturyDataGridViewTextBoxColumn,
            this.datawystawieniaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.kontrahentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.test34567BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(787, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerfakturyDataGridViewTextBoxColumn
            // 
            this.numerfakturyDataGridViewTextBoxColumn.DataPropertyName = "Numerfaktury";
            this.numerfakturyDataGridViewTextBoxColumn.HeaderText = "Numerfaktury";
            this.numerfakturyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numerfakturyDataGridViewTextBoxColumn.Name = "numerfakturyDataGridViewTextBoxColumn";
            // 
            // datawystawieniaDataGridViewTextBoxColumn
            // 
            this.datawystawieniaDataGridViewTextBoxColumn.DataPropertyName = "Datawystawienia";
            this.datawystawieniaDataGridViewTextBoxColumn.HeaderText = "Datawystawienia";
            this.datawystawieniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datawystawieniaDataGridViewTextBoxColumn.Name = "datawystawieniaDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // kontrahentDataGridViewTextBoxColumn
            // 
            this.kontrahentDataGridViewTextBoxColumn.DataPropertyName = "Kontrahent";
            this.kontrahentDataGridViewTextBoxColumn.HeaderText = "Kontrahent";
            this.kontrahentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kontrahentDataGridViewTextBoxColumn.Name = "kontrahentDataGridViewTextBoxColumn";
            // 
            // test34567BindingSource
            // 
            this.test34567BindingSource.DataMember = "test34567";
            this.test34567BindingSource.DataSource = this.tESTDataSet;
            // 
            // tESTDataSet
            // 
            this.tESTDataSet.DataSetName = "TESTDataSet";
            this.tESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test34567TableAdapter
            // 
            this.test34567TableAdapter.ClearBeforeFill = true;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "TESTDataSet";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnWydrukuj
            // 
            this.btnWydrukuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWydrukuj.Location = new System.Drawing.Point(501, 173);
            this.btnWydrukuj.Name = "btnWydrukuj";
            this.btnWydrukuj.Size = new System.Drawing.Size(116, 62);
            this.btnWydrukuj.TabIndex = 11;
            this.btnWydrukuj.Text = "Wydrukuj";
            this.btnWydrukuj.UseVisualStyleBackColor = true;
            this.btnWydrukuj.Click += new System.EventHandler(this.btnWydrukuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.Red;
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUsun.Location = new System.Drawing.Point(650, 173);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(116, 62);
            this.btnUsun.TabIndex = 12;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnAktualizujdane
            // 
            this.btnAktualizujdane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAktualizujdane.Location = new System.Drawing.Point(650, 28);
            this.btnAktualizujdane.Name = "btnAktualizujdane";
            this.btnAktualizujdane.Size = new System.Drawing.Size(116, 63);
            this.btnAktualizujdane.TabIndex = 13;
            this.btnAktualizujdane.Text = "Aktualizuj dane";
            this.btnAktualizujdane.UseVisualStyleBackColor = true;
            this.btnAktualizujdane.Click += new System.EventHandler(this.btnAktualizujdane_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdswiez.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnOdswiez.Location = new System.Drawing.Point(501, 99);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(116, 62);
            this.btnOdswiez.TabIndex = 14;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // btnEdytujdane
            // 
            this.btnEdytujdane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdytujdane.Location = new System.Drawing.Point(650, 99);
            this.btnEdytujdane.Name = "btnEdytujdane";
            this.btnEdytujdane.Size = new System.Drawing.Size(116, 62);
            this.btnEdytujdane.TabIndex = 15;
            this.btnEdytujdane.Text = "Edytuj dane";
            this.btnEdytujdane.UseVisualStyleBackColor = true;
            this.btnEdytujdane.Click += new System.EventHandler(this.btnEdytujdane_Click_1);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 461);
            this.Controls.Add(this.btnEdytujdane);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnAktualizujdane);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnWydrukuj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblDatawystawienia);
            this.Controls.Add(this.lblNumerfaktury);
            this.Controls.Add(this.cbKontrahent);
            this.Controls.Add(this.textCena);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textNumerFaktury);
            this.Controls.Add(this.btnDodaj);
            this.Name = "form1";
            this.Text = "Program do faktur";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test34567BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox textNumerFaktury;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textCena;
        private System.Windows.Forms.ComboBox cbKontrahent;
        private System.Windows.Forms.Label lblNumerfaktury;
        private System.Windows.Forms.Label lblDatawystawienia;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TESTDataSet tESTDataSet;
        private System.Windows.Forms.BindingSource test34567BindingSource;
        private TESTDataSetTableAdapters.test34567TableAdapter test34567TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerfakturyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datawystawieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentDataGridViewTextBoxColumn;
        private TESTDataSet testDataSet1;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnAktualizujdane;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnWydrukuj;
        private System.Windows.Forms.Button btnEdytujdane;
    }
}

