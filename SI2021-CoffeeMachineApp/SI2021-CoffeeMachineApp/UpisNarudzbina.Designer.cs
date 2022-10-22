
namespace SI2021_CoffeeMachineApp
{
    partial class UpisNarudzbina
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
            this.opis = new System.Windows.Forms.TextBox();
            this.napomena = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNacinSortiranja
            // 
            this.cbNacinSortiranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacinSortiranja.FormattingEnabled = true;
            this.cbNacinSortiranja.Items.AddRange(new object[] {
            "Novije dodato",
            "Starije dodato"});
            this.cbNacinSortiranja.Location = new System.Drawing.Point(312, 496);
            this.cbNacinSortiranja.Name = "cbNacinSortiranja";
            this.cbNacinSortiranja.Size = new System.Drawing.Size(136, 21);
            this.cbNacinSortiranja.TabIndex = 62;
            this.cbNacinSortiranja.SelectedIndexChanged += new System.EventHandler(this.cbNacinSortiranja_SelectedIndexChanged);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(502, 487);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(218, 37);
            this.btnSortiraj.TabIndex = 61;
            this.btnSortiraj.Text = "Sortiraj podatke";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(502, 78);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(218, 37);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Ažuriraj narudžbinu";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(502, 35);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(218, 37);
            this.btnUpisi.TabIndex = 59;
            this.btnUpisi.Text = "Unesi narudžbinu";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "NARUDŽBINE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Opis narudžbine";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Napomena narudžbine";
            // 
            // opis
            // 
            this.opis.Location = new System.Drawing.Point(230, 87);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(218, 20);
            this.opis.TabIndex = 55;
            // 
            // napomena
            // 
            this.napomena.Location = new System.Drawing.Point(230, 53);
            this.napomena.Name = "napomena";
            this.napomena.Size = new System.Drawing.Size(218, 20);
            this.napomena.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 254);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Datum narudžbine";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(502, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 37);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Obriši narudžbinu";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UpisNarudzbina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbNacinSortiranja);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.napomena);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpisNarudzbina";
            this.Text = "Upis narudžbina";
            this.Load += new System.EventHandler(this.UpisNarudzbina_Load);
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
        private System.Windows.Forms.TextBox opis;
        private System.Windows.Forms.TextBox napomena;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
    }
}