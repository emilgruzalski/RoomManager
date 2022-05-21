using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomManagerClient
{
    public class Employee
    {
        public int NumerIndeksu { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
    }

    public class EmployeeGrid
    {
        public ObservableCollection<Employee> EmployeeList { get; set; }

        public EmployeeGrid()
        {
            EmployeeList = new ObservableCollection<Employee>();
        }
    }
}