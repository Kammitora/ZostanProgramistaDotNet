using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T5L27PracaDomowa
{
    public partial class AddEditEmployee : Form
    {
        private List<Employee> _employeeList = new List<Employee>();
        private Employee _employee = new Employee();
        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();
            tbFirstName.Select();
            _employeeList = FileHelper.Deserialize();
            if (id != 0)
            {
                Text = "Edytuj dane pracownika";
                _employee = _employeeList.Where(x => x.Id == id).FirstOrDefault();
                FillTextBoxes();
            }
            else
            {
                _employee = new Employee()
                {
                    Id = _employeeList.Count + 1
                };
            }
            FillTextBoxes();
        }

        private void FillTextBoxes()
        {
            tbId.Text = _employee.Id.ToString();
            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            dtpEmploymentDate.Value = _employee.EmploymentDate;
            tbSalary.Text = _employee.Salary.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
