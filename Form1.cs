using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SinavNotuOrtHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVeriler_Click(object sender, EventArgs e)
        {
            string notlar = "";
            StreamReader sr = new StreamReader("sinavlar.txt");
            while (true)
            {
                notlar = sr.ReadLine();
                if( notlar == null)
                {
                    break;
                }
                listBox1.Items.Add(notlar);
                string[] sinavNotlari = notlar.Split(' '); // notları ayrı ayrı hesaplmaka için "split" metodu ile string veriyi parçaladık.

                double ort = 0.4 * Convert.ToDouble(sinavNotlari[1]) + 0.6 * Convert.ToDouble(sinavNotlari[2]);
                listBox2.Items.Add(sinavNotlari[0] + ':' + ort); // >> "listBox2.Items.Add( ort);" yazarsak nota sahip olan kişinin ismi yazmaz.

            }

        }
    }
}
