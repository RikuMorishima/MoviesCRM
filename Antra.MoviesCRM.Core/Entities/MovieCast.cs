using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Entities
{
    public class MovieCast
    {
        [Column(TypeName = "int")]
        public int MovieId { get; set; }
        [Column(TypeName = "int")]
        public int CastId { get; set; }
        [Column(TypeName = "nvarchar(450)")]
        public string Character { get; set; }


        //navigation properties
        public IEnumerable<Cast> Casts { get; set; } = new List<Cast>();
        public IEnumerable<Movie> Movies { get; set; } = new List<Movie>();
    }
}
