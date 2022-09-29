using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SweetModel;
using SweetDAL;

namespace SweetIndia
{
    public partial class MainItems : Form
    {
        public MainItems()
        {
            InitializeComponent();
        }


        private void MainItems_Load(object sender, EventArgs e)
        {

        }
            
        private void ResetMainModel()
        {
            txtItemCode.Text = "";
            cmbItemName.Text = "";
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            MainModel mainModel = new MainModel()
            {
                Item_Code = Convert.ToInt32(txtItemCode.Text),
                Item_Name = cmbItemName.Text,
            };
            ADD add = new ADD();
            string ADDMessage = add.AddSweetRecord(mainModel);
            MessageBox.Show(ADDMessage);
            ResetMainModel();
           // GetData();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            MainModel mainModel = new MainModel()
            {
                Item_Code = Convert.ToInt32(txtItemCode.Text),
                Item_Name = cmbItemName.Text,
            };
            Update update = new Update();
            string UpdateMessage = update.UpdateSweetRecord(mainModel);
            MessageBox.Show(UpdateMessage);
            ResetMainModel();
            //GetData();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            MainModel mainModel = new MainModel()
            {
                Item_Code = Convert.ToInt32(txtItemCode.Text),
                //ItemName = cmbItemName.Text,
            };
            Delete delete = new Delete();
            string DeleteMessage = delete.DeleteSweetRecord(mainModel);
            MessageBox.Show(DeleteMessage);
            ResetMainModel();
           // GetData();
        }
    }
}
