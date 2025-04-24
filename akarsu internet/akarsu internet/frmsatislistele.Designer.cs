namespace akarsu_internet
{
    partial class frmsatislistele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btngerial = new System.Windows.Forms.Button();
            this.satisıd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kulaniciıd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaıd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acilisturu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acıklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satisıd,
            this.kulaniciıd,
            this.masaıd,
            this.acilisturu,
            this.baslangic,
            this.bitis,
            this.sure,
            this.tutar,
            this.acıklama});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1324, 535);
            this.dataGridView1.TabIndex = 0;
            // 
            // btngerial
            // 
            this.btngerial.Dock = System.Windows.Forms.DockStyle.Right;
            this.btngerial.Location = new System.Drawing.Point(1197, 535);
            this.btngerial.Name = "btngerial";
            this.btngerial.Size = new System.Drawing.Size(127, 106);
            this.btngerial.TabIndex = 1;
            this.btngerial.Text = "işlemi geri al";
            this.btngerial.UseVisualStyleBackColor = true;
            this.btngerial.Click += new System.EventHandler(this.btngerial_Click);
            // 
            // satisıd
            // 
            this.satisıd.DataPropertyName = "(satisıd";
            this.satisıd.HeaderText = "satış ıd";
            this.satisıd.MinimumWidth = 8;
            this.satisıd.Name = "satisıd";
            // 
            // kulaniciıd
            // 
            this.kulaniciıd.DataPropertyName = "kulanıcııd";
            this.kulaniciıd.HeaderText = "kulanıcı ıd";
            this.kulaniciıd.MinimumWidth = 8;
            this.kulaniciıd.Name = "kulaniciıd";
            // 
            // masaıd
            // 
            this.masaıd.DataPropertyName = "masaıd";
            this.masaıd.HeaderText = "masa ıd";
            this.masaıd.MinimumWidth = 8;
            this.masaıd.Name = "masaıd";
            // 
            // acilisturu
            // 
            this.acilisturu.DataPropertyName = "acilisturu";
            this.acilisturu.HeaderText = "açılış türü";
            this.acilisturu.MinimumWidth = 8;
            this.acilisturu.Name = "acilisturu";
            // 
            // baslangic
            // 
            this.baslangic.DataPropertyName = "baslama";
            this.baslangic.HeaderText = "başlama";
            this.baslangic.MinimumWidth = 8;
            this.baslangic.Name = "baslangic";
            // 
            // bitis
            // 
            this.bitis.DataPropertyName = "bitissaati";
            this.bitis.HeaderText = "bitiş saati";
            this.bitis.MinimumWidth = 8;
            this.bitis.Name = "bitis";
            // 
            // sure
            // 
            this.sure.DataPropertyName = "sure";
            this.sure.HeaderText = "süre";
            this.sure.MinimumWidth = 8;
            this.sure.Name = "sure";
            // 
            // tutar
            // 
            this.tutar.DataPropertyName = "tutar";
            this.tutar.HeaderText = "tutar";
            this.tutar.MinimumWidth = 8;
            this.tutar.Name = "tutar";
            // 
            // acıklama
            // 
            this.acıklama.DataPropertyName = "aciklama";
            this.acıklama.HeaderText = "açıklama";
            this.acıklama.MinimumWidth = 8;
            this.acıklama.Name = "acıklama";
            // 
            // frmsatislistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1324, 641);
            this.Controls.Add(this.btngerial);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmsatislistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "satışları listele";
            this.Load += new System.EventHandler(this.frmsatislistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btngerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisıd;
        private System.Windows.Forms.DataGridViewTextBoxColumn kulaniciıd;
        private System.Windows.Forms.DataGridViewTextBoxColumn masaıd;
        private System.Windows.Forms.DataGridViewTextBoxColumn acilisturu;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn acıklama;
    }
}