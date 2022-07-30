using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class CrewModel
    {
        public int Id { get; set; }
        [MaxLength(128, ErrorMessage = "Name must be less than 128 characters long")]
        public string? Name { get; set; }

        public string? Gender { get; set; }

        public string? TmdbUrl { get; set; }
        [MaxLength(2084, ErrorMessage = "Name must be less than 2084 characters long")]
        public string? ProfilePath { get; set; }

        public IEnumerable<MovieCrewModel> Movies { get; set; } = new List<MovieCrewModel>();

    }
}
