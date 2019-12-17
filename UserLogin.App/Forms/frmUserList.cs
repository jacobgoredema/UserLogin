using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLogin.App.Forms
{
    public partial class frmUserList : Form
    {
        public frmUserList()
        {
            InitializeComponent();
        }

        private void frmUserList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.dataSet.User);

        }

        private void btnAddEditUsers_Click(object sender, EventArgs e)
        {
            frmRegisterUser form = new frmRegisterUser();
            form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
