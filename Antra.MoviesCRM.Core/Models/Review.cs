using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
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

    }
}
