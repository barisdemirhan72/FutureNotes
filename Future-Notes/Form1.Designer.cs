namespace FutureNotes
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblFutureNotes = new System.Windows.Forms.Label();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblNot = new System.Windows.Forms.Label();
            this.txtNotGiris = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnGonder = new FontAwesome.Sharp.IconButton();
            this.lblNotGoruntule = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(6, 319);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(209, 36);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih Giriniz:";
            this.lblTarih.Click += new System.EventHandler(this.lblTarih_Click);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(6, 426);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(199, 36);
            this.lblSaat.TabIndex = 3;
            this.lblSaat.Text = "Saat Giriniz:";
            this.lblSaat.Click += new System.EventHandler(this.lblSaat_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblAdSoyad);
            this.panel1.Controls.Add(this.lblFutureNotes);
            this.panel1.Controls.Add(this.ıconPictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 96);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1241, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.White;
            this.lblAdSoyad.Location = new System.Drawing.Point(1038, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(252, 106);
            this.lblAdSoyad.TabIndex = 12;
            this.lblAdSoyad.Text = "Barış Demirhan 222523006";
            // 
            // lblFutureNotes
            // 
            this.lblFutureNotes.AutoSize = true;
            this.lblFutureNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblFutureNotes.Font = new System.Drawing.Font("Oswald", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFutureNotes.ForeColor = System.Drawing.Color.White;
            this.lblFutureNotes.Location = new System.Drawing.Point(89, 3);
            this.lblFutureNotes.Name = "lblFutureNotes";
            this.lblFutureNotes.Size = new System.Drawing.Size(279, 80);
            this.lblFutureNotes.TabIndex = 10;
            this.lblFutureNotes.Text = "Future Notes";
            this.lblFutureNotes.Click += new System.EventHandler(this.lblFutureNotes_Click);
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.ıconPictureBox1.IconColor = System.Drawing.Color.White;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 100;
            this.ıconPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(156, 100);
            this.ıconPictureBox1.TabIndex = 9;
            this.ıconPictureBox1.TabStop = false;
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNot.Location = new System.Drawing.Point(5, 103);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(186, 36);
            this.lblNot.TabIndex = 5;
            this.lblNot.Text = "Not Giriniz:";
            this.lblNot.Click += new System.EventHandler(this.lblNot_Click);
            // 
            // txtNotGiris
            // 
            this.txtNotGiris.BackColor = System.Drawing.SystemColors.Info;
            this.txtNotGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotGiris.Location = new System.Drawing.Point(11, 147);
            this.txtNotGiris.Name = "txtNotGiris";
            this.txtNotGiris.Size = new System.Drawing.Size(292, 166);
            this.txtNotGiris.TabIndex = 6;
            this.txtNotGiris.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Brown;
            this.lblDateTime.Location = new System.Drawing.Point(12, 621);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(260, 135);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "Time";
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGonder.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.Color.White;
            this.btnGonder.IconChar = FontAwesome.Sharp.IconChar.ShareFromSquare;
            this.btnGonder.IconColor = System.Drawing.Color.White;
            this.btnGonder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGonder.Location = new System.Drawing.Point(11, 556);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(292, 62);
            this.btnGonder.TabIndex = 29;
            this.btnGonder.Text = "Notu Gönder";
            this.btnGonder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // lblNotGoruntule
            // 
            this.lblNotGoruntule.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNotGoruntule.Location = new System.Drawing.Point(3, 0);
            this.lblNotGoruntule.Name = "lblNotGoruntule";
            this.lblNotGoruntule.Size = new System.Drawing.Size(996, 164);
            this.lblNotGoruntule.TabIndex = 30;
            this.lblNotGoruntule.Text = "Not:";
            this.lblNotGoruntule.Visible = false;
            this.lblNotGoruntule.Click += new System.EventHandler(this.lblNotGoruntule_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblNotGoruntule);
            this.panel2.Location = new System.Drawing.Point(332, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 166);
            this.panel2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(715, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "Notlar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(332, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 299);
            this.dataGridView1.TabIndex = 33;
            // 
            // ıconButton1
            // 
            this.ıconButton1.BackColor = System.Drawing.Color.Coral;
            this.ıconButton1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton1.ForeColor = System.Drawing.Color.White;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.ShareFromSquare;
            this.ıconButton1.IconColor = System.Drawing.Color.White;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.Location = new System.Drawing.Point(332, 635);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(292, 62);
            this.ıconButton1.TabIndex = 34;
            this.ıconButton1.Text = "Notu Gönder";
            this.ıconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton1.UseVisualStyleBackColor = false;
            // 
            // ıconButton2
            // 
            this.ıconButton2.BackColor = System.Drawing.Color.Gold;
            this.ıconButton2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton2.ForeColor = System.Drawing.Color.White;
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.ShareFromSquare;
            this.ıconButton2.IconColor = System.Drawing.Color.White;
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.Location = new System.Drawing.Point(693, 635);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(292, 62);
            this.ıconButton2.TabIndex = 35;
            this.ıconButton2.Text = "Notu Gönder";
            this.ıconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton2.UseVisualStyleBackColor = false;
            // 
            // ıconButton3
            // 
            this.ıconButton3.BackColor = System.Drawing.Color.LightGreen;
            this.ıconButton3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton3.ForeColor = System.Drawing.Color.White;
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.ShareFromSquare;
            this.ıconButton3.IconColor = System.Drawing.Color.White;
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.Location = new System.Drawing.Point(1044, 635);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(292, 62);
            this.ıconButton3.TabIndex = 36;
            this.ıconButton3.Text = "Notu Gönder";
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton3.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 369);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 45);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 484);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(292, 45);
            this.dateTimePicker2.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ıconButton3);
            this.Controls.Add(this.ıconButton2);
            this.Controls.Add(this.ıconButton1);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtNotGiris);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTarih);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.RichTextBox txtNotGiris;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDateTime;
        private FontAwesome.Sharp.IconButton btnGonder;
        private System.Windows.Forms.Label lblNotGoruntule;
        private System.Windows.Forms.Timer timer2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.Label lblFutureNotes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

