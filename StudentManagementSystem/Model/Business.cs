using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace StudentManagementSystem.Model
{
    public class Business
    {
        StudentManagementDb _db = null;

        public Business()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            _db = new StudentManagementDb();
        }

        internal IEnumerable<Student> Get()
        {
            return _db.Students.ToList();
        }

        internal void Delete(Student student)
        {
            var obj = _db.Students.Find(student.Id);
            _db.Students.Remove(obj);
            _db.SaveChanges();

        }

        internal void Update(Student student)
        {
            CheckValidations(student);
            if (student.Id > 0)
            {
                Student selectedStudent = _db.Students.First(c => c.Id == student.Id);
                selectedStudent.FirstName = student.FirstName;
                selectedStudent.LastName = student.LastName;
                selectedStudent.StudentId = student.StudentId;
                selectedStudent.CityOfResidence = student.CityOfResidence;
                selectedStudent.Department = student.Department;
            }
            else
            {
                _db.Students.Add(student);
            }

            _db.SaveChanges();
        }

        internal bool Login(Admin admin)
        {
            var obj = _db.Admins.FirstOrDefault(c => c.Username == admin.Username && c.Password == admin.Password);
            if (obj != null) return true;
            return false;
        }

        private void CheckValidations(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student", "Please provide required information first.");
            }

            if (string.IsNullOrEmpty(student.FirstName))
            {
                throw new ArgumentNullException("First Name", "Please enter FirstName");
            }
            else if (string.IsNullOrEmpty(student.LastName))
            {
                throw new ArgumentNullException("Last Name", "Please enter LastName");
            }
            else if (string.IsNullOrEmpty(student.StudentId))
            {
                throw new ArgumentNullException("Student ID", "Please enter StudentID");
            }
            else if ((int)student.Department == -1)
            {
                throw new ArgumentNullException("Department", "Please select Department");
            }

            var checkUniqueStudentId = IsUniqueStudentId(student);
            if (checkUniqueStudentId)
            {
                throw new ArgumentException("This Student Id is already exist !", "Student Id");
            }
        }

        private bool IsUniqueStudentId(Student student)
        {
            var isExist = _db.Students.Any(c => c.StudentId == student.StudentId && c.Id != student.Id);
            return isExist;
        }
    }
}
