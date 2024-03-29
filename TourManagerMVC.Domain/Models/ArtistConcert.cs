﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagerMVC.Domain.Models
{
    public class ArtistConcert
    {
        public int ArtistId { get;  set; }
        public virtual Artist Artist { get; set; }

        //Navigation Properties
        public int ConcertId { get; set; }
        public virtual Concert Concert { get; set; }
    }
}
