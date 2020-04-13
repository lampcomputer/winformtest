using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserSave
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void UserSaveFormButton_Click(object sender, EventArgs e)
        {
            using(var f = new UserSaveHome())
            {
                f.ShowDialog();
            }
        }

        private void UserListHomeButton_Click(object sender, EventArgs e)
        {
            using(var f = new UserListHome())
            {
                f.ShowDialog();
            }
        }
    }
}
