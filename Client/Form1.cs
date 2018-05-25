using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client.ServiceHesapla.HesaplamaServiceClient servis = new ServiceHesapla.HesaplamaServiceClient();
           double s1 = Convert.ToDouble(  txtBoxS1.Text);
            double s2 = Convert.ToDouble(txtBoxS2.Text);
            try
            {
               string islem =  comboBox1.SelectedItem.ToString();
                if (islem =="+")
                {
                    txtBoxSonuc.Text = servis.Toplama(s1, s2).ToString();
                }
                else if (islem == "-")
                {
                    txtBoxSonuc.Text = servis.Cikarma(s1, s2).ToString();
                }
                else if (islem == "*")
                {
                    txtBoxSonuc.Text = servis.Carpma(s1, s2).ToString();
                }
                else if (islem == "/")
                {
                    txtBoxSonuc.Text = servis.Bolme(s1, s2).ToString();
                }
            }
            catch (Exception)
            {

                 
            }
        }
    }
}
