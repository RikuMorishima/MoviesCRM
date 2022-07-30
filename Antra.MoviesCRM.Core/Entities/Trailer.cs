using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Entities
{
    public class Trailer
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "int")]
        public int MovieId { get; set; }
        [Column(TypeName = "nvarchar(2084)")]
        public string? TrailerUrl { get; set; }
        [Column(TypeName = "nvarchar(2084)")]
        public string? Name { get; set; }

        public Movie MovieRef { get; set; } = new();
    }
}
