using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slayt
{
    public partial class Form1 : Form
    {
        BindingList<Bitmap>resimler=new BindingList<Bitmap>();
        int sayac=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resimler.Add(Properties.Resources.indir);
            resimler.Add(Properties.Resources.indir__1_);
            //   resimler.Add(Properties.Resources.resim3);
            //  resimler.Add(Properties.Resources.resim4);
            // resimler.Add(Properties.Resources.resim5);
            timer1.Start();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            sayac %=resimler.Count;
            pictureBox1.Image= resimler[sayac];
        }
    }
}
