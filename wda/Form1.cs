using Spire.Xls;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace wda
{
    public partial class Form1 : Form
    {
        Form2 form = new Form2();

        //string[] Students = new string[5];
        // int i = 0;

        private string currentUserName;
        public Form1(string username)
        {
            InitializeComponent();
            currentUserName = username;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            string name = txtname.Text;
            string gender = "";
            string hobbies = "";
            string favcolor = cbmfavcolor.Text.Trim();
            string address = txtaddress.Text.Trim();
            string email = txtemail.Text.Trim();
            string birthdate = dtbirth.Text.Trim();
            string age = txtage.Text.Trim();
            string course = cbmcourse.Text.Trim();
            string saying = txtsayings.Text.Trim();
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();
            string profilePicture = txtprofile.Text.Trim();


            // Validation
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus(); return;
            }
            else if (int.TryParse(name, out _))
            {
                MessageBox.Show("Name cannot be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus(); return;
            }

            gender = radfemale.Checked ? radfemale.Text : radmale.Checked ? radmale.Text : "";
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkbasketball.Checked) hobbies += chkbasketball.Text + ", ";
            if (chkvolleyball.Checked) hobbies += chkvolleyball.Text + ", ";
            if (chksoccer.Checked) hobbies += chksoccer.Text + ", ";
            hobbies = hobbies.TrimEnd(',', ' ');
            if (string.IsNullOrEmpty(hobbies))
            {
                MessageBox.Show("Please select at least one hobby.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(favcolor))
            {
                MessageBox.Show("Please select a favorite color.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbmfavcolor.Focus(); return;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaddress.Focus(); return;
            }

            if (string.IsNullOrEmpty(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Focus(); return;
            }

            if (string.IsNullOrEmpty(birthdate))
            {
                MessageBox.Show("Please select a birthdate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtbirth.Focus(); return;
            }

            if (string.IsNullOrEmpty(age) || !int.TryParse(age, out int ageValue) || ageValue <= 0)
            {
                MessageBox.Show("Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtage.Focus(); return;
            }

            if (string.IsNullOrEmpty(course))
            {
                MessageBox.Show("Please select a course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbmcourse.Focus(); return;
            }

            if (string.IsNullOrEmpty(saying))
            {
                MessageBox.Show("Saying cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsayings.Focus(); return;
            }

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Focus(); return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Focus(); return;
            }

            if (string.IsNullOrEmpty(profilePicture))
            {
                MessageBox.Show("Please browse and select a profile picture.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtprofile.Focus(); return;
            }
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\wda\wda\Book1.xlsx");
            Worksheet sheet = book.Worksheets[0];



            for (int i = 2; i <= sheet.LastRow; i++) // skip header
            {
                string existingUsername = sheet.Range[i, 11].Value?.Trim();
                string existingPassword = sheet.Range[i, 12].Value?.Trim();

                if (string.Equals(existingUsername, username, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(existingPassword, password, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("A user with the same username and password already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Insert to form2 if needed
            Form2 form2 = new Form2(currentUserName);
            form2.insertate(name, gender, hobbies, favcolor, address, email, birthdate, age, course, saying, username, password, "1", profilePicture);

            // Save to Excel
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\wda\wda\Book1.xlsx");
            Worksheet sh = book.Worksheets[0];
            int r = sh.LastRow + 1;

            sh.Range[r, 1].Value = name;
            sh.Range[r, 2].Value = gender;
            sh.Range[r, 3].Value = hobbies;
            sh.Range[r, 4].Value = address;
            sh.Range[r, 5].Value = favcolor;
            sh.Range[r, 6].Value = email;
            sh.Range[r, 7].Value = birthdate;
            sh.Range[r, 8].Value = age;
            sh.Range[r, 9].Value = course;
            sh.Range[r, 10].Value = saying;
            sh.Range[r, 11].Value = username;
            sh.Range[r, 12].Value = password;
            sh.Range[r, 13].Value = "1"; // active flag
            sh.Range[r, 14].Value = profilePicture; // picture path

            book.SaveToFile("C:\\Users\\ninel\\source\\repos\\ninel\\Book1.xlsx", ExcelVersion.Version2016);

            MessageBox.Show("Successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MyLogs logs = new MyLogs();
            logs.insertLogs(currentUserName, $"Added new user: {name}");

            // Reset form
            btnADD.Visible = true;
            btnUPDATE.Visible = false;

            txtName.Clear(); txtSaying.Clear(); txtAddress.Clear(); txtAge.Clear();
            txtEmail.Clear(); txtUsername.Clear(); txtPassword.Clear(); txtProfilePicture.Clear();

            cbFavoriteColor.SelectedIndex = -1;
            cbCourse.SelectedIndex = -1;
            radMale.Checked = false;
            radFemale.Checked = false;
            cbDancing.Checked = false;
            cbReading.Checked = false;
            cbSinging.Checked = false;

            txtAge.ReadOnly = true;
            txtName.Focus();
        }


        txtname.Clear();
            radmale.Checked = false;
            radfemale.Checked = false;
            chkbasketball.Checked = false;
            chkvolleyball.Checked = false;
            chksoccer.Checked = false;
            cbmfavcolor.SelectedIndex = -1;
            txtsayings.Clear();
            txtname.Focus();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            form.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string data = "";
            string data1 = "";
            string data2 = "";
            string data3 = "";



            if (radmale.Checked) 
            {
                data = radmale.Text + "\n";
            }

            else
            {
                data = radfemale.Text + "\n";
            }

            if (chkbasketball.Checked)
            {
                data1 += chkbasketball.Text ;
            }


            if (chkvolleyball.Checked)
            {
                data1 += chkvolleyball.Text;
            }

            if (chksoccer.Checked)
            {
                data1 += chksoccer.Text;
            }
            data2 += cbmfavcolor.Text;
            data3 += txtsayings.Text;

            form.update(Convert.ToInt32(lblid.Text), txtname.Text, data, data1, data2, data3);


            MessageBox.Show("Successfully Added!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtname.Clear();
            radmale.Checked = false;
            radfemale.Checked = false;
            chkbasketball.Checked = false;
            chkvolleyball.Checked = false;
            chksoccer.Checked = false;
            cbmfavcolor.SelectedIndex = -1;
            txtsayings.Clear();

            txtname.Focus();

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthDate = DateTime.Parse(dtbirth.Text);
            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now < birthDate.AddYears(age))
            {
                age--;
            }

            txtage.Text = age.ToString();

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                txtprofile.Text = d.FileName;

            }

            string profilePath = txtprofile.Text.Trim();
        }

       

       
    }
}
