
namespace SI2021_CoffeeMachineApp
{
    partial class UpisDopremnica
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.FKProizvod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FKDobavljac = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.cbNacinSortiranja.Location = new System.Drawing.Point(312, 488);
            this.cbNacinSortiranja.Name = "cbNacinSortiranja";
            this.cbNacinSortiranja.Size = new System.Drawing.Size(136, 21);
            this.cbNacinSortiranja.TabIndex = 62;
            this.cbNacinSortiranja.SelectedIndexChanged += new System.EventHandler(this.cbNacinSortiranja_SelectedIndexChanged);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(502, 479);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(218, 37);
            this.btnSortiraj.TabIndex = 61;
            this.btnSortiraj.Text = "Sortiraj podatke";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(502, 89);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(218, 37);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Ažuriraj dopremnicu";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(502, 45);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(218, 37);
            this.btnUpisi.TabIndex = 59;
            this.btnUpisi.Text = "Unesi dopremnicu";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "DOPREMNICE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 254);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Proizvod";
            // 
            // FKProizvod
            // 
            this.FKProizvod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FKProizvod.FormattingEnabled = true;
            this.FKProizvod.Location = new System.Drawing.Point(230, 45);
            this.FKProizvod.Name = "FKProizvod";
            this.FKProizvod.Size = new System.Drawing.Size(218, 21);
            this.FKProizvod.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Dobavljač";
            // 
            // FKDobavljac
            // 
            this.FKDobavljac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FKDobavljac.FormattingEnabled = true;
            this.FKDobavljac.Location = new System.Drawing.Point(230, 105);
            this.FKDobavljac.Name = "FKDobavljac";
            this.FKDobavljac.Size = new System.Drawing.Size(218, 21);
            this.FKDobavljac.TabIndex = 65;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(502, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 37);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Obriši dopremnicu";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UpisDopremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FKDobavljac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FKProizvod);
            this.Controls.Add(this.cbNacinSortiranja);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpisDopremnica";
            this.Text = "Upis dopremnica";
            this.Load += new System.EventHandler(this.UpisDopremnica_Load);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FKProizvod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FKDobavljac;
        private System.Windows.Forms.Button btnDelete;
    }
}