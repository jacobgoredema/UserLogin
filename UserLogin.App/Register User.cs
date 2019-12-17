using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLogin.App
{
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.dataSet.User);

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void groupBoxInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void EnableButtons()
        {
            btnNewUser.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void DisableSaveCancelButtons()
        {
            btnNewUser.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DisableSaveCancelButtons();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableSaveCancelButtons();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnNewUser.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
    }
}
