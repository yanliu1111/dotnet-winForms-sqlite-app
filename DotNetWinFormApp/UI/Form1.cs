using DotNetWinFormApp.Manager;
using DotNetWinFormApp.Models;
using DotNetWinFormApp.UI;

namespace DotNetWinFormApp
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        EmployeeManager _employeeManager = new EmployeeManager();

        ApplicationDbContext _dbContext = new ApplicationDbContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void LoadData()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            var employees = employeeManager.GetAll();
            employeeDataGridView.Rows.Clear();
            foreach (var employee in employees)
            {
                employeeDataGridView.Rows.Add(employee.Id, employee.Email, employee.Phone);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
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
                employee.Name = nameTextBox.Text;
                employee.Email = emailTextBox.Text;
                employee.Phone = phoneTextBox.Text;
                if (_employeeManager.Add(employee))
                {
                    MessageBox.Show("employee has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("employee saved failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            nameTextBox.Text = String.Empty;
            emailTextBox.Clear();
            phoneTextBox.Clear();
            LoadData();
        }

        private void employeeDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = employeeDataGridView.SelectedRows[0];
                frmEmployDetail frm = new frmEmployDetail(this);
                //this.Hide();
                //frm.Show();
                frm.idLable.Text = dr.Cells[0].Value.ToString();
                frm.nameTextBox.Text = dr.Cells[1].Value.ToString();
                frm.emailTextBox.Text = dr.Cells[2].Value.ToString();
                frm.phoneTextBox.Text = dr.Cells[3].Value.ToString();
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = employeeDataGridView.SelectedRows[0];
                if (MessageBox.Show("Do you want to delete?", "Qeuestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _employeeManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Employee has been removed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ssLoadData();
                        employeeDataGridView.Rows.Remove(dr);
                    }
                    else
                    {
                        MessageBox.Show("Employee removed failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}