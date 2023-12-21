using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {

        bool optDurum=false;
        double sonuc=0;
        string opt;
        public Form1()
        {
            InitializeComponent();
        }

        private void RakamGiris(object sender, EventArgs e)
        {
            if(txtSonuc.Text=="0" || optDurum) txtSonuc.Clear();
            
            optDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void islemler(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniopt = btn.Text;
            
            lblgecmis.Text = lblgecmis.Text + txtSonuc.Text +yeniopt;

            switch(opt)
            {
                case "+": txtSonuc.Text = Convert.ToString(sonuc + Convert.ToDouble(txtSonuc.Text));
                    break;
                case "-":
                    txtSonuc.Text = Convert.ToString(sonuc - Convert.ToDouble(txtSonuc.Text));
                    break;
                case "x":
                    txtSonuc.Text = Convert.ToString(sonuc * Convert.ToDouble(txtSonuc.Text));
                    break;
                case "÷":
                    txtSonuc.Text = Convert.ToString(sonuc / Convert.ToDouble(txtSonuc.Text));
                    break;

            }
            
            sonuc= Convert.ToDouble(txtSonuc.Text);
            
            opt = yeniopt;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lblgecmis.Text = "";
            opt = "";
            sonuc = 0;
            optDurum= false; 

        }

        private void button20_Click(object sender, EventArgs e)
        {
            lblgecmis.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+":
                    txtSonuc.Text = Convert.ToString(sonuc + Convert.ToDouble(txtSonuc.Text));
                    break;
                case "-":
                    txtSonuc.Text = Convert.ToString(sonuc - Convert.ToDouble(txtSonuc.Text));
                    break;
                case "x":
                    txtSonuc.Text = Convert.ToString(sonuc * Convert.ToDouble(txtSonuc.Text));
                    break;
                case "÷":
                    txtSonuc.Text = Convert.ToString(sonuc / Convert.ToDouble(txtSonuc.Text));
                    break;

            }

            sonuc = Convert.ToDouble(txtSonuc.Text);
            opt = "";
            

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(txtSonuc.Text=="0")
            { 
                txtSonuc.Text="0";

            }
            else if(optDurum)
            {
                txtSonuc.Text = "0";
            }

            if(!txtSonuc.Text.Contains("."))
            {
                txtSonuc.Text += ",";
            }
            optDurum = false;
        }
    }
}
