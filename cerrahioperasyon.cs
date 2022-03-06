using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proje
{
    public partial class cerrahioperasyon : Form
    {
        double kilo, boy, yas;
        string ad, soyad;
        kullanıcıgiris a;
        public cerrahioperasyon(double boy,double kilo,double yas,string ad,string soyad,kullanıcıgiris a)
        {
            InitializeComponent();
            this.boy = boy;
            this.kilo = kilo;
            this.yas = yas;
            this.ad = ad;
            this.soyad = soyad;
            this.a = a;
        }

        private void Rdbtn1c1_CheckedChanged(object sender, EventArgs e)
        {

        }

      

        private void btnkayıtcrhioperasyon_Click(object sender, EventArgs e)
        {
            //projeadminEntities db = new projeadminEntities();
            //Kullanicilar k=new Kullanicilar();
            Dictionary<string, string> json = new Dictionary<string, string>();
            double puan=0;
            

            if (rdbtn1c1.Checked)
            {
                puan += 3;
                json.Add("Soru1", "0");
                //k.Soru1 = "0";
               
            }
            else if (rdbtn1c2.Checked)
            {
                puan += 6;
                json.Add("Soru1", "1");
                //k.Soru1 = "1";
                
            }
            else if (rdbtn1c3.Checked)
            {
                puan += 9;
                //k.Soru1 = "2";
                json.Add("Soru1", "2");
                
            }
            else if (rdbtn1c4.Checked)
            {
                puan += 12;
                //k.Soru1 = "3";
                json.Add("Soru1", "3");
               
            }

            if(rdbtn2c1.Checked)
            {
                puan += 10;
                //k.Soru2 = "0";
                json.Add("Soru2", "0");
            }
            else if(rdbtn2c2.Checked)
            {
                //k.Soru2 = "1";
                json.Add("Soru2", "2");
            }

            if(rdbtn3evet.Checked)
            {
                puan += 6;
                //k.Soru3 = "0";
                json.Add("Soru3", "0");
            }
            else if(rdbtnsoru3hyr.Checked)
            {
                //k.Soru3 = "1";
                json.Add("Soru3", "1");
            }

            if(rdbtnevet4.Checked)
            {
                puan += 5;
                //k.Soru4 = "0";
                json.Add("Soru4", "0");
            }
            else if(rdbtn4hyr.Checked)
            {
                //k.Soru4 = "1";
                json.Add("Soru4", "1");
            }

            if(rsbntsr5c1.Checked)
            {
                puan += 3;
                //k.Soru5 = "0";
                json.Add("Soru5", "0");
            }
            else if(rdbtns5c2.Checked)
            {
                puan += 6;
                //k.Soru5 = "1";
                json.Add("Soru5", "1");
            }
            else if(rdbtns5c3.Checked)
            {
                puan += 9;
                //k.Soru5 = "2";
                json.Add("Soru5", "2");


            }
            else if(rdbtnsoru5c4.Checked)
            {
                puan += 12;
                //k.Soru5 = "3";
                json.Add("Soru5", "3");
            }

            if(rdbtn6c1.Checked)
            {
                puan += 5;
                //k.Soru6 = "0";
                json.Add("Soru6", "0");

            }
            else if(rdbtn6c2.Checked)
            {
                //k.Soru6 = "1";
                json.Add("Soru6", "1");
            }

            if(rdbtn7c1.Checked)
            {
                puan += 5;
                //k.Soru7 = "0";
                json.Add("Soru7", "0");
            }
            else if(rdbtn7c2.Checked)
            {
                //k.Soru7 = "1";
                json.Add("Soru7", "1");
            }

            puan = (puan * 60) / 100;
            double puan2;
            puan2 = (kilo / (boy * boy));
            double final = puan + puan2;
            //k.Puan = final;
            json.Add("Puan", final.ToString());
            MessageBox.Show("Veriler başarıyla kayıt altına alındı");
            //db.Kullanicilars.Add(k);
            //db.SaveChanges();
            json.Add("Ad", ad);
            json.Add("Soyad", soyad);
            Program.db.GetCollection<Dictionary<string, string>>("kullanicilar").InsertOne(json);
            this.Close();
            a.Show();
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //rdbtn1c1.Checked=
            if (rdbtn1c1.Checked==true)
            {

            }
        }

        private void btnsonucgorcrhope_Click(object sender, EventArgs e)
        {
           
            
            this.Hide();

        }
    }
}

       