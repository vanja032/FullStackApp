
namespace SI2021_CoffeeMachineApp
{
    partial class UpisEvidencija
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
            this.cbNacinSortiranja = new System.Windows.Forms.ComboBox();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.napomena = new System.Windows.Forms.TextBox();
            this.opis = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.FKProizvod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FKNarudzbina = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNacinSortiranja
            // 
            this.cbNacinSortiranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacinSortiranja.FormattingEnabled = true;
            this.cbNacinSortiranja.Items.AddRange(new object[] {
            "ID narudžbine opadajuce",
            "ID narudžbine rastuće",
            "Naziv proizvoda opadajuće",
            "Naziv proizvoda rastuće"});
            this.cbNacinSortiranja.Location = new System.Drawing.Point(312, 504);
            this.cbNacinSortiranja.Name = "cbNacinSortiranja";
            this.cbNacinSortiranja.Size = new System.Drawing.Size(136, 21);
            this.cbNacinSortiranja.TabIndex = 74;
            this.cbNacinSortiranja.SelectedIndexChanged += new System.EventHandler(this.cbNacinSortiranja_SelectedIndexChanged);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(502, 495);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(218, 37);
            this.btnSortiraj.TabIndex = 73;
            this.btnSortiraj.Text = "Sortiraj podatke";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(502, 95);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(218, 37);
            this.btnUpdate.TabIndex = 72;
            this.btnUpdate.Text = "Ažuriraj evidenciju";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(502, 52);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(218, 37);
            this.btnUpisi.TabIndex = 71;
            this.btnUpisi.Text = "Unesi evidenciju";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "EVIDENCIJE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Napomena evidencije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Opis evidencije";
            // 
            // napomena
            // 
            this.napomena.Location = new System.Drawing.Point(230, 78);
            this.napomena.Name = "napomena";
            this.napomena.Size = new System.Drawing.Size(218, 20);
            this.napomena.TabIndex = 67;
            // 
            // opis
            // 
            this.opis.Location = new System.Drawing.Point(230, 52);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(218, 20);
            this.opis.TabIndex = 66;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 254);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Narudžbina";
            // 
            // FKProizvod
            // 
            this.FKProizvod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FKProizvod.FormattingEnabled = true;
            this.FKProizvod.Location = new System.Drawing.Point(230, 131);
            this.FKProizvod.Name = "FKProizvod";
            this.FKProizvod.Size = new System.Drawing.Size(218, 21);
            this.FKProizvod.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Proizvod";
            // 
            // FKNarudzbina
            // 
            this.FKNarudzbina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FKNarudzbina.FormattingEnabled = true;
            this.FKNarudzbina.Location = new System.Drawing.Point(230, 104);
            this.FKNarudzbina.Name = "FKNarudzbina";
            this.FKNarudzbina.Size = new System.Drawing.Size(218, 21);
            this.FKNarudzbina.TabIndex = 75;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(502, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 37);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = "Obriši evidenciju";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UpisEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FKProizvod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FKNarudzbina);
            this.Controls.Add(this.cbNacinSortiranja);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.napomena);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpisEvidencija";
            this.Text = "Upis evidencija";
            this.Load += new System.EventHandler(this.UpisEvidencija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNacinSortiranja;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox napomena;
        private System.Windows.Forms.TextBox opis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FKProizvod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FKNarudzbina;
        private System.Windows.Forms.Button btnDelete;
    }
}