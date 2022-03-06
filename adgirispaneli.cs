using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MongoDB.Driver;
using MongoDB.Bson;

namespace proje
{
    public partial class adgirispaneli : Form
    {
        public adgirispaneli()
        {
            InitializeComponent();

        }

        private void Geribtn_Click(object sender, EventArgs e)
        {
            girisfrm frm = new girisfrm();
            frm.Show();
            this.Hide();           

        }
        
        private void Grisbtn_Click(object sender, EventArgs e)
        {
            //projeadminEntities db = new projeadminEntities();
            //var gelen = db.Admin1.ToList();


            BsonDocument a = Program.db.GetCollection<BsonDocument>("admin").
                Find(new BsonDocument { { "K_Adi", kaditxtbox.Text }, { "Sifre", sifretxtbox.Text } }).
                    FirstOrDefault();
            /*foreach (var item in gelen)
            {
                if(item.K_Adi==kaditxtbox.Text)
                {

                    if(item.Sifre==sifretxtbox.Text)
                    {
                        
                        this.Hide();
                        bayrak = true;
                    }
                }
            }*/
            if(a!=null)
            {
                adminpaneli admpnl = new adminpaneli(this, a.GetValue("K_Adi").ToString());
                this.Hide();
                admpnl.Show();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }


        }

        private void kaditxtbox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
