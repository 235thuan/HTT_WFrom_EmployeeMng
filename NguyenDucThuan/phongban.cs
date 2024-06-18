using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDucThuan
{
    public partial class frmPhongban : Form
    {
        private ListDepartment lstDprt;
        public frmPhongban()
        {
            InitializeComponent();
            lstDprt = new ListDepartment();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (lbDspb.SelectedIndex != -1) 
            {
                string newDepartmentName = txtTenpb.Text.Trim();

                if (!string.IsNullOrEmpty(newDepartmentName))
                {
                    // Update selected department
                    Department selectedDepartment = (Department)lbDspb.SelectedItem;
                    selectedDepartment.DepartmentName = newDepartmentName;

                    loadLb();

                    MessageBox.Show($"Department '{newDepartmentName}' updated successfully.");
                }
                else
                {
                    MessageBox.Show("Please enter a department name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a department to update.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string newDepartment = txtTenpb.Text.Trim();
            if (!string.IsNullOrEmpty(newDepartment))
            {
                lstDprt.AddDepartment(newDepartment);
                txtTenpb.Text = "";
                loadLb();
            }
            else
            {
                MessageBox.Show("Please enter a department name.");
            }
        }
        private void loadLb()
        {
            lbDspb.DataSource = null;
            lbDspb.DataSource = lstDprt.GetDepartments();
            lbDspb.DisplayMember = "DepartmentName";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lbDspb.SelectedIndex != -1) 
            {
                Department selectedDepartment = (Department)lbDspb.SelectedItem;
                string departmentName = selectedDepartment.DepartmentName;

                DialogResult result = MessageBox.Show($"Are you sure you want to delete department '{departmentName}'?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lstDprt.RemoveDepartment(selectedDepartment);

                    loadLb();

                    MessageBox.Show($"Department '{departmentName}' deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a department to delete.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQuanlynv f = new frmQuanlynv();
            f.Show();
            this.Hide();
        }

        private void frmPhongban_Load(object sender, EventArgs e)
        {
            loadLb();
        }

        private void lbDspb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDspb.SelectedIndex != -1) 
            {
                Department selectedDepartment = (Department)lbDspb.SelectedItem;
                txtTenpb.Text = selectedDepartment.DepartmentName;
            }
        }
    }
}
