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

        Form2 form2 = new Form2();  
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            string name = txtname.Text;

            //data += txtName.Text + ", ";
            string gender = "";

            if (radmale.Checked)
            {
                //string male = rdoMale.Checked;

                gender = radmale.Text;
            }

            if (radfemale.Checked)
            {
                gender = radfemale.Text;
            }

            string hobby = "";

            if (chkbasketball.Checked)
            {
                hobby += chkbasketball.Text + ", ";
            }

            if (chkvolleyball.Checked)
            {
                hobby += chkvolleyball.Text + ", ";
            }

            if (chksoccer.Checked)
            {
                hobby += chksoccer.Text + ", ";
            }

            string favColor = cbmfavcolor.Text;

            string saying = txtsayings.Text;

            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\wda\wda\Book1.xlsx");
            Worksheet sheet = book.Worksheets[0];

            int row = sheet.Rows.Length + 1;

            sheet.Range[row, 1].Value = Name;
            sheet.Range[row, 2].Value = gender;
            sheet.Range[row, 3].Value = hobby;
            //sheet.Range[row, 4].Value = txtAddress.Text;
            //sheet.Range[row, 5].Value = txtEmail.Text;
            //sheet.Range[row, 6].Value = dtpBirthday.Text;
            //sheet.Range[row, 7].Value = txtAge.Text;
            sheet.Range[row, 8].Value = favColor;
            sheet.Range[row, 9].Value = saying;
            //sheet.Range[row, 10].Value = txtUsername.Text;
            //sheet.Range[row, 11].Value = txtPassword.Text;

            book.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\wda\wda\Book1.xlsx", ExcelVersion.Version2016);
            DataTable dt = sheet.ExportDataTable();

            //form2.dataGridView1.DataSource = dt;

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


        }

       
    }
}
