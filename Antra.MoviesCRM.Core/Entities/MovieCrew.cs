using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Entities
{
    public class MovieCrew
    {
        [Column(TypeName="int")]
        public int MovieId { get; set; }
        [Column(TypeName = "int")]
        public int CrewId { get; set; }
        [Column(TypeName = "nvarchar(128)")]
        public string Department { get; set; }
        [Column(TypeName = "nvarchar(128)")]
        public string Job { get; set; }

    }
}
