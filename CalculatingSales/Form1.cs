using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatingSales
{
   public partial class frmSales : Form
   {
      public frmSales()
      {
         InitializeComponent();
      }

      private void txtProduct3_TextChanged(object sender, EventArgs e)
      {

      }

      private void btnCalculate_Click(object sender, EventArgs e)
      {
         CalculateAndDisplaySales();
      }


      private void CalculateAndDisplaySales()
      {
         int counter = 1;
         double totalRetailValue = 0;
         double productPrice = 0;


         while (counter <= 3)
         {
            switch (counter)
            {
               case 1:
                  productPrice = 2.98;
                  totalRetailValue = totalRetailValue + (productPrice * int.Parse(txtProduct1.Text));
                  break;
               case 2:
                  productPrice = 4.50;
                  totalRetailValue = totalRetailValue + (productPrice * int.Parse(txtProduct2.Text));
                  break;
               case 3:
                  productPrice = 9.98;
                  totalRetailValue = totalRetailValue + (productPrice * int.Parse(txtProduct3.Text));
                  break;
            }

            ++counter;

         }

         lblSalesOutput.Text = "The total sales is: " + totalRetailValue.ToString("C");
      }

      private void frmSales_Load(object sender, EventArgs e)
      {

      }

      private void txtProduct1_TextChanged(object sender, EventArgs e)
      {

      }

      private void txtProduct2_TextChanged(object sender, EventArgs e)
      {

      }
   }
}
