using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class ReviewModel
    {

        public int MovieId { get; set; }

        public int UserId { get; set; }
        [Required]
        public decimal Rating { get; set; }

        [Required]
        public string? ReviewText { get; set; }

    }
}
