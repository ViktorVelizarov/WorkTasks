using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTasks.Forms
{
    public partial class UserMainPage : Form
    {
        public UserMainPage()
        {
            InitializeComponent();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new HomePage();
            temp.Show();
        }
    }
}
