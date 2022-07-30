using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class MovieGenreModel
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }

        public IEnumerable<GenreModel> Genres { get; set; } = new List<GenreModel>();
        public IEnumerable<MovieModel> Movies { get; set; } = new List<MovieModel>();
    }
}
