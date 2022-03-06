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
using MongoDB.Bson;
namespace proje
{
    public partial class kullanıcıgiris : Form
    {
        public kullanıcıgiris()
        {
            InitializeComponent();
        }

       

        private void Yesrdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ks1c1.Checked == true)
            {
                double boy, kilo, yas;
                boy = Convert.ToDouble(cmboxboy.SelectedItem.ToString()) / 100;
                kilo = Convert.ToDouble(cmboxkg.SelectedItem.ToString());
                yas = Convert.ToDouble(cmboxyas.SelectedItem.ToString());
                string ad, soyad;
                ad = txtad.Text;
                soyad = txtsad.Text;
                cerrahioperasyon crh = new cerrahioperasyon(boy,kilo,yas,ad,soyad,this);
                this.Hide();
                crh.Show();
            }

        }
       
        private void Kullanıcıgiris_Load(object sender, EventArgs e)
        {

            for (int i = 20; i <= 90; i++)
            {
                cmboxyas.Items.Add(i);
            }
            for (int j =65; j <= 200; j++)
            {
                cmboxkg.Items.Add(j); 
            }
            for (int hk = 150; hk < 220; hk++)
            {
                cmboxboy.Items.Add(hk);
            }
                
            
        }

        //double final;
        private void Kullanicigrisbtn_Click(object sender, EventArgs e)
        {

            projeadminEntities db = new projeadminEntities();
            Kullanicilar k = new Kullanicilar();
            Dictionary<string, string> json = new Dictionary<string, string>();
            double puan = 0;
            if (ks1c2.Checked)
            {
                json.Add("Soru1", "1");
                //k.Soru1 = "1";
            }
               

            if (ks2c1.Checked)
            {
                json.Add("Soru2", "0");
                puan += 5;
                //k.Soru2 = "0";
            }
            else if (ks2c2.Checked)
            {
                json.Add("Soru2", "1");
                //k.Soru2 = "1";
            }


            if(ks3c1.Checked)
            {
                puan += 20;
                //k.Soru3 = "0";
                json.Add("Soru", "0");
            }
            else if (ks3c2.Checked)
            {
                puan += 15;
                //k.Soru3 = "1";
                json.Add("Soru3", "1");
            }
            else if (ks3c3.Checked)
            {
                puan += 10;
                //k.Soru3 = "2";
                json.Add("Soru3", "2");
            }
            else if (ks3c4.Checked)
            {
                
                //k.Soru3 = "4";
                json.Add("Soru3", "4");
            }

            if (ks4c1.Checked)
            {
                puan += 5;
                //k.Soru4 = "0";
                json.Add("Soru4", "0");
            }
            else if (ks4c2.Checked)
            {

                //k.Soru4 = "1";
                json.Add("Soru4", "1");
            }

            if (ks5c5.Checked)
            {
                puan += 5;
                //k.Soru5 = "0";
                json.Add("Soru5", "0");
            }
            else if (ks5c2.Checked)
            {
               
                //k.Soru5 = "1";
                json.Add("Soru5", "1");
            }

            if(ks6c1.Checked)
            {
                puan += 12;
                //k.Soru6 = "0";
                json.Add("Soru6", "0");
            }
            else if(ks6c2.Checked)
            {
                puan += 9;
                //k.Soru6 = "1";
                json.Add("Soru6", "1");
            }
            else if(ks6c3.Checked)
            {
                puan += 6;
                //k.Soru6 = "2";
                json.Add("Soru6", "2");
            }
            else if(ks6c4.Checked)
            {
                puan += 3;
                //k.Soru6 = "3";
                json.Add("Soru6", "3");
            }

            if(ks7c1.Checked)
            {
               
                //k.Soru7 = "0";
                json.Add("Soru7", "0");
            }
            else if(ks7c2.Checked)
            {
                puan += 8;
                //k.Soru7 = "1";
                json.Add("Soru7", "1");
            }

            double boy, kilo, yas;
            boy = Convert.ToDouble(cmboxboy.SelectedItem.ToString());
            kilo = Convert.ToDouble(cmboxkg.SelectedItem.ToString());
            yas = Convert.ToDouble(cmboxyas.SelectedItem.ToString());
            
            //k.Ad = txtad.Text;
            json.Add("Ad", txtad.Text);
            //k.Soyad = txtsad.Text;
            json.Add("Soyad", txtsad.Text);
            //k.Boy = Convert.ToInt32(boy);
            json.Add("Boy", Convert.ToInt32(boy).ToString());
            //k.Kilo = Convert.ToInt32(kilo);
            json.Add("Kilo", Convert.ToInt32(kilo).ToString());
            //k.Yas = Convert.ToInt32(yas);
            json.Add("Yas", Convert.ToInt32(yas).ToString());
            double puan2;
            puan = (puan * 60) / 100;
            puan2 = (kilo/(boy *boy));
            double final = puan + puan2;
            //k.Puan = final;
            json.Add("Puan", final.ToString());
            //db.Kullanicilars.Add(k);
            MessageBox.Show("Veriler başarıyla kayıt altına alındı");
            Program.db.GetCollection<Dictionary<string, string>>("kullanicilar").InsertOne(json);
            //db.SaveChanges();

            
           
           
        }

        private void btn2verigoster_Click(object sender, EventArgs e)
        {
            sonuç snc = new sonuç();
            snc.Show();
            this.Hide();
            
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            girisfrm enter = new girisfrm();
            enter.Show();
            this.Hide();
            

        }
    }
}

