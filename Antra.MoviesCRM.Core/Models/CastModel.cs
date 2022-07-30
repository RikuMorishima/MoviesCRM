using Antra.MoviesCRM.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class CastModel
    {
        public int Id { get; set; }
        [MaxLength(128, ErrorMessage = "Name must be less than 128 characters long")]
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? TmdbUrl { get; set; }
        public string? ProfilePath { get; set; }

        //Navigation Properties
        public IEnumerable<MovieCastModel> Movies { get; set; } = new List<MovieCastModel>();

    }
}
