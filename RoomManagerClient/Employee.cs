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

    public class Employee_grid
    {
        public ObservableCollection<Employee> Employee_list { get; set; }

        public Employee_grid()
        {
            Employee_list = new ObservableCollection<Employee>();
        }
    }
}