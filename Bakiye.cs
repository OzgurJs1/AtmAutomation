using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public partial class Bakiye : Form
    {
        public Bakiye()
        {
            InitializeComponent();
        }

        private void Bakiye_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.mBakiye.ToString() + "TL";
            HareketKaydet.Kaydet(Form1.mID, "Bakiye Sorgulandı");
            
        }
    }
}
