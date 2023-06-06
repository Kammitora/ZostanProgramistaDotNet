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
    public partial class EmploeesDiary : Form
    {
        private List<Employee> _employees = new List<Employee>();
        public EmploeesDiary()
        {
            InitializeComponent();
            RefreshDiary();
            FillColumnNames();
        }

        private void FillColumnNames()
        {
            dgvDiary.Columns[0].HeaderText = "Numer";
            dgvDiary.Columns[1].HeaderText = "Imię";
            dgvDiary.Columns[2].HeaderText = "Nazwisko";
            dgvDiary.Columns[3].HeaderText = "Data zatrudnienia";
            dgvDiary.Columns[4].HeaderText = "Zwolniony";
            dgvDiary.Columns[5].HeaderText = "Data zwolnienia";
            dgvDiary.Columns[6].HeaderText = "Wynagrodzenie";
        }

        private void RefreshDiary()
        {
            _employees = FileHelper.Deserialize();
            dgvDiary.DataSource = _employees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditEmployee addEditEmployee = new AddEditEmployee();
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing; 
            addEditEmployee.ShowDialog();

        }

        private void AddEditEmployee_FormClosing(object sender, EventArgs e)
        {
            RefreshDiary();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddEditEmployee addEditEmployee = new AddEditEmployee(Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value));
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            var employee = _employees.Where(x => x.Id == Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value)).FirstOrDefault();
            if (employee.IsFired)
            {
                MessageBox.Show("Ta osoba jest już zwolniona", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = MessageBox.Show($"Czy na pewno chcesz zwolić {employee.FirstName} {employee.LastName}?", "Zwolnienie pracownika",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.No:
                        {
                            break;
                        }
                    case DialogResult.Yes:
                        {
                            _employees.Remove(employee);
                            employee.IsFired = true;
                            employee.DismissalDate = DateTime.Now;
                            _employees.Add(employee);
                            FileHelper.Serialize(_employees);
                            RefreshDiary();
                            break;
                        }
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFilter.SelectedItem)
            {
                case "Wszyscy":
                    {
                        dgvDiary.DataSource = _employees;
                        break;
                    }
                case "Zatrudnieni":
                    {
                        dgvDiary.DataSource = _employees.Where(x => x.IsFired == false).ToList();
                        break;
                    }
                case "Zwolnieni":
                    {
                        dgvDiary.DataSource = _employees.Where(x => x.IsFired == true).ToList();
                        break;
                    }
            }
            
        }
    }
}
