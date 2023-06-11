using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleGraph
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void UserNameText_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void UserPassText_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoginBottan_Click(object sender, EventArgs e)
        {
            if (UserNameText.Text == "User")
            {
                if (UserPassText.Text == "0000")
                {
                    ScheduleMain a = new ScheduleMain();
                    a.Show();
                }else
                {
                    MessageBox.Show("パスワードが誤っております。");
                }
            }
            else
            {
                MessageBox.Show("ユーザが存在しません。");
                UserNameText.Text = "";
            }
        }
    }
}
