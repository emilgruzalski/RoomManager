using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomManagerClient
{
    public class Room
    {
        public int Id { get; set; }
        public string Building { get; set; }
        public string Phone_number { get; set; }
        public string Purpose { get; set; }
        public int Number_of_desk { get; set; }
    }

    public class Room_grid
    {
        public ObservableCollection<Room> Room_list { get; set; }

        public Room_grid()
        {
            Room_list = new ObservableCollection<Room>();
            Room_list.Add(new Room()
            {
                Building = "Administracja",
                Phone_number = "234524321",
                Purpose = "Recepcja",
                Number_of_desk = 4,
                Id = 1
            });
            Room_list.Add(new Room()
            {
                Building = "Hala produkcyjna",
                Phone_number = "318765321",
                Purpose = "Kotłownia",
                Number_of_desk = 2,
                Id = 2
            });
        }
    }
}