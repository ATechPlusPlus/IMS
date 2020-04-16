using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMS.Other_Forms
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
        //DataTable dtPurchaseInvoice = new DataTable();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //DataRow dRow = dtPurchaseInvoice.NewRow();
            //dtPurchaseInvoice.Rows.Add(dRow);
            //dtPurchaseInvoice.AcceptChanges();
            //dataGridView1.DataSource = dtPurchaseInvoice;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = "";
            int newInteger;
            if (dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }
            if (!int.TryParse(e.FormattedValue.ToString(), out newInteger) || newInteger < 0)
            {
                e.Cancel = true;
                dataGridView1.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
            }
        }
    }
}
