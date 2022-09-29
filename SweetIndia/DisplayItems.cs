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
    public partial class DisplayItems : Form
    {
        public DisplayItems()
        {
            InitializeComponent();
        }
        private void ResetDisplayModel()
        {
            txtItemCode.Text = "";
            cmbName.Text = "";
            cmbMainItem.Text = "";
        }

        private void bnREAD_Click(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            DisplayModel displayModel = new DisplayModel()
            {
                ItemCode = Convert.ToInt32(txtItemCode.Text),
                Name = cmbName.Text,
                MainItem=cmbMainItem.Text,
            };
            ADD add = new ADD();
            string ADDMessage = add.AddSweetRecord(displayModel);
            MessageBox.Show(ADDMessage);
            ResetDisplayModel();
           // GetData();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {

            DisplayModel displayModel = new DisplayModel()
            {
                ItemCode = Convert.ToInt32(txtItemCode.Text),
                Name = cmbName.Text,
                MainItem = cmbMainItem.Text,
            };
            Update update = new Update();
            string UpdateMessage = update.UpdateSweetRecord(displayModel);
            MessageBox.Show(UpdateMessage);
            ResetDisplayModel();
            //GetData();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {

            DisplayModel displayModel = new DisplayModel()
            {
                ItemCode = Convert.ToInt32(txtItemCode.Text),
               // Name = cmbName.Text,
                //MainItem = cmbMainItem.Text,
            };
            Delete delete= new Delete();
            string DeleteMessage = delete.DeleteSweetRecord(displayModel);
            MessageBox.Show(DeleteMessage);
            ResetDisplayModel();
            //GetData();
        }
    }
}
