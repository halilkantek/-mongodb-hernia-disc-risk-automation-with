using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace proje
{
    public partial class adminpaneli : Form
    {
        projeadminEntities db = new projeadminEntities();
        adgirispaneli a;
        
        public adminpaneli(adgirispaneli a,string ad)
        {
            InitializeComponent();
            this.a = a;
            MessageBox.Show("Hoşgeldiniz " + ad);
            doldur();
            
        }

        void doldur()
        {
            List<BsonDocument> list = Program.db.GetCollection<BsonDocument>("kullanicilar").Find(new BsonDocument()).ToList();
            foreach (BsonDocument item in list)
            {
                string[] a = { item.GetValue("_id").ToString(), item.GetValue("Ad").ToString(), item.GetValue("Soyad").ToString(), item.GetValue("Puan").ToString() };
                dataGridView1.Rows.Add(a);


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string secilen = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", BsonObjectId.Parse(secilen));
            Program.db.GetCollection<BsonDocument>("kullanicilar").DeleteOne(filter);
            dataGridView1.Rows.Clear();
            doldur();
            

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=null)
            {
                string id = textBox1.Text;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if(item.Cells[0].Value.ToString()==id)
                    {
                        MessageBox.Show("ID=" + item.Cells[0].Value.ToString()
                            +"\n"+"Ad="+item.Cells[1].Value.ToString()
                            +"\n"+ "Soyad"+item.Cells[2].Value.ToString()
                            +"\n"+"Puan"+item.Cells[3].Value.ToString());
                        break;

                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            double deger = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            if (deger <= 30)
                label4.Text = "Risksizdir";
            else if (deger >= 30 || deger < 50)
                label4.Text = "Normal";
            else if (deger >= 50 || deger < 80)
                label4.Text = "Riskli";
            else if (deger >= 80)
                label4.Text = "Çok Riskli";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.Show();
            this.Close();
        }
    }
}
