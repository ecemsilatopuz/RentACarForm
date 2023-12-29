using RentACarForm.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarForm
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void btn_LoginInto_Click(object sender, EventArgs e)
        {
            AppUserForm appUserForm = LoginUser.GetAppUserForm();

            MessageBox.Show(appUserForm.UserName);
        }
    }
}
