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

            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\wda\wda\Book1.xlsx");

            Worksheet sheet = book.Worksheets[0];

            int row = sheet.Rows.Length; 

            bool log = false;

            for (int i = 2; i < row; i++)
            {
                string storedUsername = sheet.Range[i, 11].Value?.Trim();
                string storedPassword = sheet.Range[i, 12].Value?.Trim();
                string accountStatus = sheet.Range[i, 13].Value?.Trim();

                if (storedUsername == txtusername.Text.Trim() && storedPassword == txtpassword.Text.Trim())
                {
                    //validate if account is inactive
                    if (accountStatus == "0")
                    {
                        MessageBox.Show("Your account is inactive. Login Failed", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        log = true;
                        txtusername.Clear(); txtpassword.Clear();
                        break;
                    }

                    string profilePath = sheet.Range[i, 14].Text;
                    string name = storedUsername;

                    MessageBox.Show("Login successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    log.insertLogs(storedUsername, "Successfully logged in!");

                    Dashboard dashboard = new Dashboard(name, profilePath);
                    dashboard.ShowDialog();
                    loginSuccess = true;
                    this.Close();
                    break;
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

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }
    }
    
}

        
           
    

