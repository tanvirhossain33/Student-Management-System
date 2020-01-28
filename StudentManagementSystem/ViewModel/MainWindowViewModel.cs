using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementSystem.Infrastructure;
using StudentManagementSystem.Model;

namespace StudentManagementSystem.ViewModel
{
    public class MainWindowViewModel : NotificationClass
    {
        Business _business;
        private Student _student;
        public EventHandler ShowMessageBox = delegate { };
        public MainWindowViewModel()
        {
            _business = new Business();
            StudentCollection = new ObservableCollection<Student>(_business.Get());
            ResetStudent();
        }

        private ObservableCollection<Student> studentCollection;
        public ObservableCollection<Student> StudentCollection
        {
            get { return studentCollection; }
            set
            {
                studentCollection = value;
                OnPropertyChanged();
            }
        }
        public Student SelectedStudent
        {
            get
            {
                return _student;
            }
            set
            {
                _student = value;
                OnPropertyChanged();
            }
        }


        public RelayCommand Reset
        {
            get
            {
                return new RelayCommand(ResetStudent, true);
            }
        }

        private void ResetStudent()
        {
            try
            {
                SelectedStudent = new Student();
            }
            catch (Exception ex)
            {
                ShowMessageBox(this, new MessageEventArgs()
                {
                    Message = ex.Message
                });
            }
        }

        public RelayCommand Save
        {
            get
            {
                return new RelayCommand(SaveStudent, true);
            }
        }

        private void SaveStudent()
        {
            try
            {
                _business.Update(SelectedStudent);
                StudentCollection = new ObservableCollection<Student>(_business.Get());
                ResetStudent();
                ShowMessageBox(this, new MessageEventArgs()
                {
                    Message = "Changes are saved !"
                });
            }
            catch (Exception ex)
            {
                ShowMessageBox(this, new MessageEventArgs()
                {
                    Message = ex.Message
                });
            }

        }

        public RelayCommand Delete
        {
            get
            {
                return new RelayCommand(DeleteStudent, true);
            }
        }

        private void DeleteStudent()
        {
            try
            {
                _business.Delete(SelectedStudent);
                StudentCollection = new ObservableCollection<Student>(_business.Get());
                ResetStudent();
            }
            catch (Exception e)
            {
                ShowMessageBox(this, new MessageEventArgs()
                {
                    Message = "Delete Failed !! Select any item from the list to delete it."
                });
            }
            
        }


    }
}
