using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationApp_Tejano_Danica
{
    public partial class frmRegistration : Form
    {
        DataTable dt = new DataTable();

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtCourse.Text) || string.IsNullOrWhiteSpace(cbDept.Text)) 
            {
                MessageBox.Show("Pls fill out all nessesary inputs", "Invalid!");
            }
            else
            { 
                dt.Rows.Add(txtLname.Text+", "+txtFname.Text, txtCourse.Text, cbDept.Text);
                grData.DataSource = dt;

                txtFname.Clear();
                txtLname.Clear();
                txtCourse.Clear();
                cbDept.SelectedIndex = -1;
            }
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("NAME");
            dt.Columns.Add("COURSE");
            dt.Columns.Add("DEPARTMENT");
        }
    }
}
