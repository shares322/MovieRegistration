using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class MovieRequest
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public GenreType Genre { get; set; }
        
        public DateTime date { get; set; }

        [StringLength(50)]
        public string Actors { get; set; }

        [StringLength(50)]
        public string Directors { get; set; }
    }
}