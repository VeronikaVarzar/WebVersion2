using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class HotelRoom
    {
        public HotelRoom()
        {
            RoomsForRent = new HashSet<RoomForRent>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public int Floor { get; set; }
        public int TypeId { get; set; }

        public virtual RoomType Type { get; set; }
        public virtual ICollection<RoomForRent> RoomsForRent { get; set; }
    }
}
