using System;
using System.Data;
using System.Windows.Forms;
using WhatsAppApi;

namespace roku
{
    public partial class Form1 : Form
    {
        public string Gonderen = "";

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
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
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
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

        private void Gonder()
        {

            if (dataGridView1.Rows.Count - 1 <= 0)
            {
                DurumListBox.Items.Add("Listeye kişi eklenmemiş.");
            }
            else
            {
                DurumListBox.Items.Add("Listeye " + (dataGridView1.Rows.Count - 1) + " kişi eklenmiş.");
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
                MessageBox.Show("Tekrar deneyin:" + ex);
            }

            WhatsApp wp = new WhatsApp(Gonderen, "Gonderen WhatsApp Password", "Gonderen WhatsApp Name", false, false);

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
                    DurumListBox.Items.Add("Whatsapp girişi başarısız:" + data);
                };
                wp.Login();

            };
            wp.OnConnectFailed += (ex) =>
            {
                DurumListBox.Items.Add("Whatsapp bağlantısı başarısız:" + ex);
            };
        }


        private void gonder_Click(object sender, EventArgs e)
        {

            Gonder();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //Gonder();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
            DateTimeOffset target = (DateTimeOffset)dateTimePicker1.Value;

            if (now.ToUnixTimeSeconds() == target.ToUnixTimeSeconds())
            {
                if (dataGridView1.Rows.Count - 1 <= 0)
                {
                    DurumListBox.Items.Add("Listeye kişi eklenmediği için mesajlar belirlenen tarihte gönderilemedi.");
                }
                else
                {
                    DurumListBox.Items.Add("Zamanalama tarihi geldiği için mesajlar " + (dataGridView1.Rows.Count - 1) + " kişiye gönderildi.");
                    Gonder();
                }
            }

            //DurumListBox.Items.Add("Now:" + now.ToUnixTimeSeconds() + "-" + "Target:" + target.ToUnixTimeSeconds());
            //DurumListBox.Items.Add(target.ToUnixTimeSeconds());

            //DurumListBox.Items.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        }


    }
}
