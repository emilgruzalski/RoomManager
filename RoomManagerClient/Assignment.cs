using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomManagerClient
{
    public class Assignment
    {
        public int NumerIndeksu { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
    }

    public class Assignment_grid
    {
        public ObservableCollection<Assignment> Assignment_list { get; set; }

        public Assignment_grid()
        {
            Assignment_list = new ObservableCollection<Assignment>();
        }
    }
}