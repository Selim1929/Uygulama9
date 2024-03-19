using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama9
{
    public partial class Form1 : Form
    {
        int[,] dizi;
        int satirSayisi;
        int sutunSayisi;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiziOlustur_Click(object sender, EventArgs e)
        {
            {
                int rastgeleMin = int.Parse(txtRastgeleMin.Text);
                int rastgeleMax = int.Parse(txtRastgeleMax.Text);
                satirSayisi = int.Parse(txtSatırSayısı.Text);
                sutunSayisi = int.Parse(txtSütünSayısı.Text);
                dizi = new int[satirSayisi, sutunSayisi];
                Random rastgele = new Random();
                for (int x = 0; x < satirSayisi; x++)
                {
                    for (int y = 0; y < sutunSayisi; y++)
                    {
                        dizi[x, y] = rastgele.Next(rastgeleMin, rastgeleMax);
                    }
                }
            }
        }

        private void btnDiziGöster_Click(object sender, EventArgs e)
        {
            {
                for (int x = 0; x < satirSayisi; x++)
                {
                    for (int y = 0; y < sutunSayisi; y++)
                    {
                        btnListele.Items.Add(x +","+y +" => "+dizi[x, y]);
                    }
                }
            }
        }
    }
}
