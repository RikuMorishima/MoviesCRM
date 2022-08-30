using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class MovieCastModel
    {
        public int MovieId { get; set; }
        public int CastId { get; set; }

        [MaxLength(450, ErrorMessage = "Character must be less than 450 characters long")]
        public string Character { get; set; }

        public MovieModel Movie { get; set; }
        public CastModel Cast { get; set; }
    }
}
