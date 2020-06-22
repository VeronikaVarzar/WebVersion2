using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class Hotel
    {
        public Hotel()
        {
            RoomTypes = new HashSet<RoomType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TownId { get; set; }

        public virtual Town Town { get; set; }
        public virtual ICollection<RoomType> RoomTypes { get; set; }
    }
}
