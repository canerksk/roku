using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace roku
{
    public partial class Form1 : Form
    {
        string Gonderen = "";

        public Form1()
        {
           
            InitializeComponent();
            GonderenTextBox.Text = Gonderen;
        }

        private void import_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox2.Text = openFileDialog1.FileName;
            DosyaGetir(textBox2.Text);
            DurumListBox.Items.Add("Kişiler içeri aktarıldı.");
        }



        private void DosyaGetir(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

        }

        private void gonder_Click(object sender, EventArgs e)
        {
            int AlanCount = dataGridView1.Rows.Count - 1;

            if (AlanCount <= 0)
            {

                DurumListBox.Items.Add("Listeye kişi eklenmemiş.");
            }
            else
            {
                DurumListBox.Items.Add("Listeye " + AlanCount + " kişi eklenmiş.");

            }

            string Alan = null;
            string Mesaj = GonderilenMesajRichTextBox.Text;



            try
            {
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {

                    for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                    {


                        Alan = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("try again" + ex);
            }


            WhatsApp wp = new WhatsApp(Gonderen, "WhatsApp Password", "WhatsApp Nickname", false, false);

            wp.OnConnectSuccess += () =>
            {
                DurumListBox.Items.Add("Whatsapp'a bağlanıyor...");

                wp.OnLoginSuccess += (phoneNumber, data) =>
                {
                    wp.SendMessage(Alan, Mesaj);
                    DurumListBox.Items.Add("Mesaj gönderiliyor...");
                };

                wp.OnLoginFailed += (data) =>
                {
                    DurumListBox.Items.Add("Whatsapp bağlantısı başarısız:" + data);
                };
                wp.Login();

            };
            wp.OnConnectFailed += (ex) =>
            {
                DurumListBox.Items.Add("Whatsapp bağlantısı başarısız:" + ex);
            };

        }

        private void GonderilenMesajRichTextBox_click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Can reis böyle istiyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (d == DialogResult.OK)
                GonderilenMesajRichTextBox.Text = "Numaram değişti yeni numaram budur.";  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }


    }
}
