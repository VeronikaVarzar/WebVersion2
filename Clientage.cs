using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class Client
    {
        public Client()
        {
            RoomsForRent = new HashSet<RoomForRent>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string PassportId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<RoomForRent> RoomsForRent { get; set; }
    }
}
