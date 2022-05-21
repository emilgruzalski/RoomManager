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
        public int RoomIndex { get; set; }
        public string Building { get; set; }
        public string PhoneNumber { get; set; }
        public string Purpose { get; set; }
        public int NumberOfDesk { get; set; }
    }

    public class RoomGrid
    {
        public ObservableCollection<Room> RoomList { get; set; }

        public RoomGrid()
        {
            RoomList = new ObservableCollection<Room>();
            RoomList.Add(new Room()
            {
                Building = "Administracja",
                PhoneNumber = "234524321",
                Purpose = "Recepcja",
                NumberOfDesk = 4,
                RoomIndex = 1
            });
            RoomList.Add(new Room()
            {
                Building = "Hala produkcyjna",
                PhoneNumber = "318765321",
                Purpose = "Kotłownia",
                NumberOfDesk = 2,
                RoomIndex = 2
            });
        }
    }
}