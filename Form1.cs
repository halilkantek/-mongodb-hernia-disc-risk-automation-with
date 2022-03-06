using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class girisfrm : Form
    {
        static projeadminEntities db = new projeadminEntities();
        
        public girisfrm()
        {
            InitializeComponent();
        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            
            adgirispaneli adgris = new adgirispaneli();
            adgris.Show();
            this.Hide();
        }

        private void Kullanıcıbtn_Click(object sender, EventArgs e)
        {
            kullanıcıgiris kgiris = new kullanıcıgiris();
            kgiris.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
