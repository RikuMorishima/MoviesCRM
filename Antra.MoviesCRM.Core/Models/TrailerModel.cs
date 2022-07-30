using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class TrailerModel
    {

        public int Id { get; set; }

        public int MovieId { get; set; }
        [MaxLength(2084, ErrorMessage = "Name must be less than 64 characters long")]
        public string? TrailerUrl { get; set; }
        [MaxLength(2084, ErrorMessage = "Name must be less than 64 characters long")]
        public string? Name { get; set; }
    }
}
