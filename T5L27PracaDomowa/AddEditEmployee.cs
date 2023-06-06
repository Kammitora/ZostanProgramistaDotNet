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
        private Employee _employee = new Employee();
        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();
            tbFirstName.Select();
            var employeeList = FileHelper.Deserialize();
            if (id != 0)
            {
                Text = "Edytuj dane pracownika";
                _employee = employeeList.Where(x => x.Id == id).FirstOrDefault();
            }
            else
            {
                _employee = new Employee()
                {
                    Id = employeeList.Count + 1
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
            var employeeList = FileHelper.Deserialize();
            employeeList.RemoveAll(x => x.Id == _employee.Id);

            _employee.Id = Convert.ToInt32(tbId.Text);
            _employee.FirstName = tbFirstName.Text;
            _employee.LastName = tbLastName.Text;
            _employee.EmploymentDate = dtpEmploymentDate.Value;
            _employee.Salary = Convert.ToInt32(tbSalary.Text);

            employeeList.Add(_employee);

            FileHelper.Serialize(employeeList);

            Close();
        }
    }
}
