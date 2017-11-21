/*
 * Name: Anju Chawla
 * Date: November, 2017
 * Purpose: This applicatiopn allows a customer a buy 
 * coffee in bulk.
 * All transactions willl be saved and can be printed
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkCoffeeSales2017
{
    public partial class frmBulkCoffeeSales : Form
    {
        private struct CoffeeSale
        {
            public String quantity;
            public String type;
            public decimal price;
        };

        //number of transactions that can be saved
        private const int MaximumTransactions = 5;
        //save the transactions in an array
        private CoffeeSale[] transactionsCoffeeSales =
            new CoffeeSale[MaximumTransactions];
        //save transactions in a list
        private List<CoffeeSale> transactionsCoffeeSalesList =
            new List<CoffeeSale>();

        private string selectedButtonName;
        private int transactionNumber = 0; //be default


        public frmBulkCoffeeSales()
        {
            InitializeComponent();
        }

        private void frmBulkCoffeeSales_Load(object sender, EventArgs e)
        {
            rdoQuarterPound.Checked = true;
            selectedButtonName = "rdoQuarterPound";
        }
        /// <summary>
        /// The application is terminated
        /// </summary>
        /// <param name="sender">The Exit button</param>
        /// <param name="e">Event arguments</param>

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
/// <summary>
/// Clear the input selections and the output
/// </summary>
/// <param name="sender">The Clear button</param>
/// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoQuarterPound.Checked = true;
            selectedButtonName = "rdoQuarterPound";
            cboType.SelectedIndex = -1;
            txtPrice.Clear();


        }
    }
}
