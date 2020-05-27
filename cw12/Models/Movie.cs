using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cw12.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]//what will be shown
        [DataType(DataType.Date)]//show only date
        public DateTime ReleaseDate { get; set; }//user does not enter  time
        public string Genre { get; set; }

        //jako decimal z dokładnością 18 i skalą 2
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string Rating { get; set; }
    }
}