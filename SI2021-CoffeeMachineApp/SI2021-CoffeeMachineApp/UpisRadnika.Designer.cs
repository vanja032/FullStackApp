
namespace SI2021_CoffeeMachineApp
{
    partial class UpisRadnika
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
            this.FKRukovodilac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.cbNacinSortiranja = new System.Windows.Forms.ComboBox();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.jmbg = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FKRukovodilac
            // 
            this.FKRukovodilac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FKRukovodilac.FormattingEnabled = true;
            this.FKRukovodilac.Location = new System.Drawing.Point(230, 159);
            this.FKRukovodilac.Name = "FKRukovodilac";
            this.FKRukovodilac.Size = new System.Drawing.Size(218, 21);
            this.FKRukovodilac.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "Rukovodilac radnika";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Telefon radnika";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(230, 81);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(218, 20);
            this.telefon.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "Prezime radnika";
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(230, 55);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(218, 20);
            this.prezime.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Ime radnika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Email radnika";
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(230, 29);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(218, 20);
            this.ime.TabIndex = 85;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(230, 133);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(218, 20);
            this.email.TabIndex = 84;
            // 
            // cbNacinSortiranja
            // 
            this.cbNacinSortiranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacinSortiranja.FormattingEnabled = true;
            this.cbNacinSortiranja.Items.AddRange(new object[] {
            "Ime rastuće",
            "Ime opadajuće",
            "Prezime rastuće",
            "Prezime opadajuće",
            "Novije dodato",
            "Starije dodato"});
            this.cbNacinSortiranja.Location = new System.Drawing.Point(312, 564);
            this.cbNacinSortiranja.Name = "cbNacinSortiranja";
            this.cbNacinSortiranja.Size = new System.Drawing.Size(136, 21);
            this.cbNacinSortiranja.TabIndex = 83;
            this.cbNacinSortiranja.SelectedIndexChanged += new System.EventHandler(this.cbNacinSortiranja_SelectedIndexChanged);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(502, 555);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(218, 37);
            this.btnSortiraj.TabIndex = 82;
            this.btnSortiraj.Text = "Sortiraj podatke";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(502, 73);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(218, 37);
            this.btnUpdate.TabIndex = 81;
            this.btnUpdate.Text = "Ažuriraj radnika";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(502, 29);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(218, 37);
            this.btnUpisi.TabIndex = 80;
            this.btnUpisi.Text = "Unesi radnika";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "RADNICI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Password radnika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Username radnika";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(230, 212);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(218, 20);
            this.password.TabIndex = 76;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(230, 186);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(218, 20);
            this.username.TabIndex = 75;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 254);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 95;
            this.label9.Text = "JMBG radnika";
            // 
            // jmbg
            // 
            this.jmbg.Location = new System.Drawing.Point(230, 107);
            this.jmbg.MaxLength = 13;
            this.jmbg.Name = "jmbg";
            this.jmbg.Size = new System.Drawing.Size(218, 20);
            this.jmbg.TabIndex = 94;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(502, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 37);
            this.btnDelete.TabIndex = 96;
            this.btnDelete.Text = "Obriši radnika";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UpisRadnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.jmbg);
            this.Controls.Add(this.FKRukovodilac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.email);
            this.Controls.Add(this.cbNacinSortiranja);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpisRadnika";
            this.Text = "Upis radnika";
            this.Load += new System.EventHandler(this.UpisRadnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FKRukovodilac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ComboBox cbNacinSortiranja;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox jmbg;
        private System.Windows.Forms.Button btnDelete;
    }
}