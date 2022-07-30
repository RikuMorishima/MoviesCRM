using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Entities
{
    public class Review
    {
        [Column(TypeName = "int")]
        public int MovieId { get; set; }
        [Column(TypeName = "int")]
        public int UserId { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public decimal Rating { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string? ReviewText { get; set; }

        public IEnumerable<Movie> Movies { get; set; } = new List<Movie>();
        public IEnumerable<User> Users { get; set; } = new List<User>();

    }
}
