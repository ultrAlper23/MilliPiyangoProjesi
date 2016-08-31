using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilliPiyango
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bilet bilet;

        void BiletGelsin()
        {
            bilet = new Bilet();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BiletGelsin();
            txtBilet.Text = bilet.BiletNo;

           // Piyango p = new Piyango();

            Piyango.Cekilis();
            SiraliListe();
        }

        void SiraliListe()
        {
            lbAmorti.Items.Clear();
            lbSon3.Items.Clear();
            lbSon2.Items.Clear();

            lbAmorti.Items.AddRange(Piyango.Amorti.ToArray());
            lbSon2.Items.AddRange(Piyango.Son2.ToArray());
            lbSon3.Items.AddRange(Piyango.Son3.ToArray());
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            //substring stringin belirli kısmını almamızı sağlar
            string son3 = bilet.BiletNo.Substring(3);
            string son2 = bilet.BiletNo.Substring(4);
            string son = bilet.BiletNo.Substring(5);
            //3 veya 4 veya 5 indexinden başlayıp sonuna kadar alır.

            if (lbSon3.Items.Contains(son3))
            {
                lbSon3.SelectedItem = son3;
                MessageBox.Show("Son 3 basamağa göre ikramiye kazandınız", "İkramiye");
            }
            else if (lbSon2.Items.Contains(son2))
            {
                lbSon2.SelectedItem = son2;
                MessageBox.Show("Son 2 basamağa göre ikramiye kazandınız", "İkramiye");
            }
            else if (lbAmorti.Items.Contains(son))
            {
                lbAmorti.SelectedItem = son;
                MessageBox.Show("Amorti kazandınız", "İkramiye");
            }
            else
                MessageBox.Show("İkramiye kazanamadınız.", "Oooohh nooo!..");
        }

        private void btnYeniCekilis_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

    }
}
