using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class MovieCrewModel
    {
        public int MovieId { get; set; }
        public int CrewId { get; set; }
        [MaxLength(128, ErrorMessage = "OriginalLanguage must be less than 128 characters long")]
        public string Department { get; set; }
        [MaxLength(128, ErrorMessage = "OriginalLanguage must be less than 128 characters long")]
        public string Job { get; set; }

    }
}
