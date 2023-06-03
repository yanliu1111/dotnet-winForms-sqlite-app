using DotNetWinFormApp.Manager;
using DotNetWinFormApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetWinFormApp.UI
{
    public partial class frmEmployDetail : Form
    {
       
        FrmEmployee frm;

        public frmEmployDetail(FrmEmployee frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        EmployeeManager _employeeManager = new EmployeeManager();
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Please enter name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(emailTextBox.Text))
                {
                    MessageBox.Show("Please enter email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(phoneTextBox.Text))
                {
                    MessageBox.Show("Please enter phone.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    phoneTextBox.Focus();
                    return;
                }
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(idLable.Text);
                employee.Name = nameTextBox.Text;
                employee.Email = emailTextBox.Text;
                employee.Phone = phoneTextBox.Text;
                if (_employeeManager.Update(employee))
                {
                    MessageBox.Show("employee has been modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm.LoadData();
                 }
                else
                {
                    MessageBox.Show("employee modify failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
