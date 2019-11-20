using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.PointOfService;

namespace SWDprojekt
{
    class Booking
    {
        public ObservableCollection<Deltager> Deltagere { get; set; }
        public DateTime Dato{ get; set; }
        public Bane ValgtBane{ get; set; }

        public Booking(List<Deltager> delagere, DateTime dato, Bane valgtBane){
            Deltagere = delagere;
            Dato = dato;
            ValgtBane = valgtBane;
        }

        public void Deltagere()
        {
            Deltagere = new ObservableCollection<Deltager>();
            {
                Deltagere.Add= new Deltager(DateTime.Now,ValgtBane);
            }
        }

        public void Add()
        {
            Booking.Add(new Booking(Deltager, DateTime.Now, ValgtBane));
        }
    }
}
