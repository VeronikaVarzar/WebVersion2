using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class RoomForRent
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime DateOfEviction { get; set; }
        public int HotelRoomId { get; set; }

        public virtual Client Client { get; set; }
        public virtual HotelRoom HotelRoom { get; set; }
    }
}
