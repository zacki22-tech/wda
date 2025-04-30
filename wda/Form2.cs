using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace wda
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadExcelFile();
        }

        public void LoadExcelFile() 
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\wda\wda\Book1.xlsx");
            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
            dataGridView1.DataSource = dt;
        }

        /*C:\Users\ACT-STUDENT\Downloads*/

        //int indexRow;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void info(string name, string gender, string hobbies, string favcolor, string sayings)
        {
            int i = dataGridView1.Rows.Add();
            this.dataGridView1.Rows[i].Cells[0].Value = name;
            this.dataGridView1.Rows[i].Cells[1].Value = gender;
            this.dataGridView1.Rows[i].Cells[2].Value = hobbies;
            this.dataGridView1.Rows[i].Cells[3].Value = favcolor;
            this.dataGridView1.Rows[i].Cells[4].Value = sayings;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                this.dataGridView1.Rows.Remove(row);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;

            Form1 form = (Form1)Application.OpenForms["Form1"];

            form.txtname.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();

            string gender = dataGridView1.Rows[i].Cells[1].Value.ToString();
            if (gender == "Male")
            {
                form.radmale.Checked = true;
            }
            else
            {
                form.radfemale.Checked = true;
            }

            string hobbies = dataGridView1.Rows[i].Cells[2].Value.ToString();
            string[] h = hobbies.Split(',');
            foreach (string val in h)
            {
                if (val.Trim() == "Basketball")
                {
                    form.chkbasketball.Checked = true;
                }

                if (val.Trim() == "Volleyball")
                {
                    form.chkvolleyball.Checked = true;
                }

                if (val.Trim() == "Soccer")
                {
                    form.chksoccer.Checked = true;
                }
            }

            form.cbmfavcolor.SelectedItem = dataGridView1.Rows[i].Cells[3].Value.ToString();
            form.txtsayings.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            form.lblid.Text = i.ToString();
            form.btnadd.Visible = false;
            form.btnupdate.Visible = true;

        }

        
        public void update(int id, string name, string gender, string hobbies, string favcolor, string sayings)
        {
            int i = dataGridView1.Rows.Add();
            this.dataGridView1.Rows[id].Cells[0].Value = name;
            this.dataGridView1.Rows[id].Cells[1].Value = gender;
            this.dataGridView1.Rows[id].Cells[2].Value = hobbies;
            this.dataGridView1.Rows[id].Cells[3].Value = favcolor;
            this.dataGridView1.Rows[id].Cells[4].Value = sayings;
        }



        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(txtsearch.Text))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search not found. Please try again.");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
