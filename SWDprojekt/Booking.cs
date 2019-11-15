using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.PointOfService;

namespace SWDprojekt
{
    class Booking
    {
        public List<Deltager> Delagere { get; set; }
        public DateTime Dato{ get; set; }
        public Bane ValgtBane{ get; set; }

        public Booking(List<Deltager> delagere, DateTime dato, Bane valgtBane){
            Delagere = delagere;
            Dato = dato;
            ValgtBane = valgtBane;
        }

    }
}
