
namespace SI2021_CoffeeMachineApp
{
    partial class UpisProizvodjaca
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
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.TextBox();
            this.drzava = new System.Windows.Forms.TextBox();
            this.naziv = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.opis = new System.Windows.Forms.TextBox();
            this.cbNacinSortiranja = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(502, 483);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(218, 37);
            this.btnSortiraj.TabIndex = 34;
            this.btnSortiraj.Text = "Sortiraj podatke";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(502, 84);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(218, 37);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Ažuriraj proizvođača";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(502, 40);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(218, 37);
            this.btnUpisi.TabIndex = 32;
            this.btnUpisi.Text = "Unesi proizvođača";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "PROIZVOĐAČI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Adresa proizvođača";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Država proizvođača";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Naziv proizvođača";
            // 
            // adresa
            // 
            this.adresa.Location = new System.Drawing.Point(230, 101);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(218, 20);
            this.adresa.TabIndex = 21;
            // 
            // drzava
            // 
            this.drzava.Location = new System.Drawing.Point(230, 75);
            this.drzava.Name = "drzava";
            this.drzava.Size = new System.Drawing.Size(218, 20);
            this.drzava.TabIndex = 20;
            // 
            // naziv
            // 
            this.naziv.Location = new System.Drawing.Point(230, 49);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(218, 20);
            this.naziv.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 254);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Opis proizvođača";
            // 
            // opis
            // 
            this.opis.Location = new System.Drawing.Point(230, 127);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(218, 20);
            this.opis.TabIndex = 36;
            // 
            // cbNacinSortiranja
            // 
            this.cbNacinSortiranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacinSortiranja.FormattingEnabled = true;
            this.cbNacinSortiranja.Items.AddRange(new object[] {
            "Naziv rastuće",
            "Naziv opadajuće",
            "Novije dodato",
            "Starije dodato"});
            this.cbNacinSortiranja.Location = new System.Drawing.Point(312, 492);
            this.cbNacinSortiranja.Name = "cbNacinSortiranja";
            this.cbNacinSortiranja.Size = new System.Drawing.Size(136, 21);
            this.cbNacinSortiranja.TabIndex = 38;
            this.cbNacinSortiranja.SelectedIndexChanged += new System.EventHandler(this.cbNacinSortiranja_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(502, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 37);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Obriši proizvođača";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UpisProizvodjaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbNacinSortiranja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.drzava);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpisProizvodjaca";
            this.Text = "Upis proizvodjaca";
            this.Load += new System.EventHandler(this.UpisProizvodjaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.TextBox drzava;
        private System.Windows.Forms.TextBox naziv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox opis;
        private System.Windows.Forms.ComboBox cbNacinSortiranja;
        private System.Windows.Forms.Button btnDelete;
    }
}