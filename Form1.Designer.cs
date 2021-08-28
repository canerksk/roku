
namespace roku
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GonderilenMesajRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GonderenTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.import = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DurumLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DurumListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 308);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gonder);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.GonderilenMesajRichTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.GonderenTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mesaj";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gonder
            // 
            this.gonder.Location = new System.Drawing.Point(606, 17);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(143, 59);
            this.gonder.TabIndex = 4;
            this.gonder.Text = "Gönder";
            this.gonder.UseVisualStyleBackColor = true;
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gönderilecek Mesaj;";
            // 
            // GonderilenMesajRichTextBox
            // 
            this.GonderilenMesajRichTextBox.Location = new System.Drawing.Point(18, 89);
            this.GonderilenMesajRichTextBox.Name = "GonderilenMesajRichTextBox";
            this.GonderilenMesajRichTextBox.Size = new System.Drawing.Size(731, 171);
            this.GonderilenMesajRichTextBox.TabIndex = 2;
            this.GonderilenMesajRichTextBox.Text = "Numaram değişti yeni numaram budur.";
            this.GonderilenMesajRichTextBox.Click += new System.EventHandler(this.GonderilenMesajRichTextBox_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gönderenin Numarası:";
            // 
            // GonderenTextBox
            // 
            this.GonderenTextBox.Location = new System.Drawing.Point(172, 17);
            this.GonderenTextBox.Name = "GonderenTextBox";
            this.GonderenTextBox.Size = new System.Drawing.Size(150, 22);
            this.GonderenTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.import);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İçe Aktar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(489, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 207);
            this.dataGridView1.TabIndex = 2;
            // 
            // import
            // 
            this.import.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.import.Location = new System.Drawing.Point(608, 6);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(31, 22);
            this.import.TabIndex = 1;
            this.import.Text = "...";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Zamanlama";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gönderim Tarih/Saati;";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(359, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // DurumLabel
            // 
            this.DurumLabel.AutoSize = true;
            this.DurumLabel.Location = new System.Drawing.Point(13, 323);
            this.DurumLabel.Name = "DurumLabel";
            this.DurumLabel.Size = new System.Drawing.Size(54, 17);
            this.DurumLabel.TabIndex = 5;
            this.DurumLabel.Text = "Durum:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DurumListBox
            // 
            this.DurumListBox.FormattingEnabled = true;
            this.DurumListBox.ItemHeight = 16;
            this.DurumListBox.Location = new System.Drawing.Point(16, 355);
            this.DurumListBox.Name = "DurumListBox";
            this.DurumListBox.Size = new System.Drawing.Size(768, 100);
            this.DurumListBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "İçe aktarılanlar;";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "CSV Dosyası:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.DurumListBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DurumLabel);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roku Şeysi";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox GonderilenMesajRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GonderenTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button gonder;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label DurumLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox DurumListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

