using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class GenreModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(64, ErrorMessage = "Name must be less than 64 characters long")]
        public string Name { get; set; }

        public IEnumerable<MovieModel> Movies { get; set; } = new List<MovieModel>();
    }
}
