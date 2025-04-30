using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;

namespace wda
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //f2.Insert(name,gender,hobbies,color,saying);
            Workbook book = new Workbook();

            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\wda\wda\Book1.xlsx");

            Worksheet sheet = book.Worksheets[0];

            int row = sheet.Rows.Length; 

            bool log = false;

            for (int i = 2; i < row; i++)
            {
                if (sheet.Range[2, 9].Value == txtusername.Text && sheet.Range[2, 10].Value == txtpassword.Text)
                {
                    log = true;//success
                    break;
                }
                else
                {
                    log = false;//invalid
                }
            }

            if (log == true)
            {
                MessageBox.Show("Successful login");

                Dashboard form3 = new Dashboard();

                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid login, please enter correct username and password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void chkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpass.Checked) 
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }
    }
    
}

        
           
    

