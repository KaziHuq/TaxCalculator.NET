using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxApp

{

    public partial class Form1 : Form
    {
        double iTax, iTotal,  iSubTotal;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {


            TaxClass t1 = new TaxClass();
            t1.totalAmount = double.Parse(txtBox1.Text);
            iSubTotal = t1.GetTotalAmount();
            iTax = t1.GetTax(iSubTotal);

            iTotal = iSubTotal + iTax;

            txtBox1.Text = String.Format("{0:C}", iSubTotal);
            txtBox2.Text = String.Format("{0:C}", iTax);
            txtBox3.Text = String.Format("{0:C}", iTotal);

            
        }

    }

}