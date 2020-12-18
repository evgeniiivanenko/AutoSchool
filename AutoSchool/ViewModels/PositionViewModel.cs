using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AutoSchool.ViewModels
{
    public class PositionViewModel : ViewModelBase, IDataErrorInfo
    {
        private int id;
        private string name;
        private decimal salary;

        public PositionViewModel()
        {

        }

        public PositionViewModel(PositionViewModel pwm)
        {
            Id = pwm.Id;
            Name = pwm.Name;
            Salary = pwm.Salary;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                OnPropertyChanged("Salary");
            }
        }

        public string this[string columnName]
        {

            get
            {

                if (columnName == "Name" && string.IsNullOrEmpty(Name))
                    return "Некорректный ввод названия!";

                if (columnName == "Salary" && Salary < 1)
                    return "Зарплата не может быть меньше 1";

                return null;
            }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }
    }
}
