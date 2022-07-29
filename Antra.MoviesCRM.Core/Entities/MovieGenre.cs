using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Entities
{
    public class MovieGenre
    {
        [Column(TypeName = "int")]
        public int MovieId { get; set; }
        [Column(TypeName = "int")]
        public int GenreId { get; set; }
    }
}
