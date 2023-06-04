using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class AddEditStudent : Form
    {
        private FileHelper<List<Student>> _fileHelper = new FileHelper<List<Student>>(Program.FilePath);
        private Student _student;
        private int _studentId;

        public AddEditStudent(int id = 0)
        {
            _studentId = id;
            InitializeComponent();
            GetStudentData(_studentId);
            tbFirstName.Select();
        }

        private void GetStudentData(int id)
        {
            if (id != 0)
            {
                Text = "Edytowanie ucznia";
                var students = _fileHelper.DeserializeFromFile();
                _student = students.FirstOrDefault(x => x.Id == id);

                if (_student == null)
                {
                    throw new Exception("Brak Użytkownika o takim ID!");
                }

                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            tbId.Text = _student.Id.ToString();
            tbFirstName.Text = _student.FirstName;
            tbLastName.Text = _student.LastName;
            cmbGroup.SelectedItem = _student.Group;
            tbMath.Text = _student.Math;
            tbTechnology.Text = _student.Technology;
            tbPhysics.Text = _student.Physics;
            tbPolishLang.Text = _student.PolishLang;
            tbForeignLang.Text = _student.ForeignLang;
            cbExtraClasses.Checked = _student.ExtraClasses;
            rtbComments.Text = _student.Comments;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile();

            if (_studentId != 0)
            {
                students.RemoveAll(x => x.Id == _studentId);
            }
            else
            {
                AssignIdToNewStudent(students);
            }

            AddNewUserToList(students);

            _fileHelper.SerializeToFile(students);

            Close();

        }

        private void AddNewUserToList(List<Student> students)
        {
            var student = new Student
            {
                Id = _studentId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Group = cmbGroup.SelectedItem.ToString(),
                Math = tbMath.Text,
                Technology = tbTechnology.Text,
                Physics = tbPhysics.Text,
                PolishLang = tbPolishLang.Text,
                ForeignLang = tbForeignLang.Text,
                ExtraClasses = cbExtraClasses.Checked,
                Comments = rtbComments.Text
            };

            students.Add(student);
        }

        private void AssignIdToNewStudent(List<Student> students)
        {
            var studentWithHighestId = students.OrderByDescending(x => x.Id).FirstOrDefault();
            _studentId = studentWithHighestId == null ? 1 : studentWithHighestId.Id + 1;
        }
    }
}
