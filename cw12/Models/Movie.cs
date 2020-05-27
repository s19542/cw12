﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw12.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]//show only date
        public DateTime ReleaseDate { get; set; }//user does not enter  time
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}