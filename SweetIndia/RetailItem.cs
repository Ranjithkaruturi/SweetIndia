using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SweetDAL;
using SweetModel;

namespace SweetIndia
{
    public partial class RetailItem : Form
    {
        public RetailItem()
        {
            InitializeComponent();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            RetailModel retailModel = new RetailModel()
            {
                ItemCode = Convert.ToInt32(txtItemCode.Text),
                Name = cmbName.Text,
                DisplayItem = cmbDisplayItem.Text,
            };
            Update update = new Update();
            string UpdateMessage = update.UpdateSweetRecord(retailModel);
            MessageBox.Show(UpdateMessage);
            ResetRetailModel();
            //GetData();
        }

        private void lblDisplayName_Click(object sender, EventArgs e)
        {

        }
        private void ResetRetailModel()
        {
            txtItemCode.Text = "";
            cmbName.Text = "";
            cmbDisplayItem.Text = "";
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            RetailModel retailModel = new RetailModel()
            {
                ItemCode = Convert.ToInt32(txtItemCode.Text),
                Name = cmbName.Text,
                DisplayItem =cmbDisplayItem.Text,
            };
            ADD add = new ADD();
            string ADDMessage = add.AddSweetRecord(retailModel);
            MessageBox.Show(ADDMessage);
            ResetRetailModel();
           // GetData();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            RetailModel retailModel = new RetailModel()
            {
                ItemCode = Convert.ToInt32(txtItemCode.Text),
                //ItemName = cmbItemName.Text,
            };
            Delete delete = new Delete();
            string DeleteMessage = delete.DeleteSweetRecord(retailModel);
            MessageBox.Show(DeleteMessage);
            ResetRetailModel();
            //GetData();
        }
    }
}
