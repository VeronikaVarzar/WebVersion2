using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class Town
    {
        public Town()
        {
            Hotels = new HashSet<Hotel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
