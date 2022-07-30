using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class UserRole
    {
        [Column(TypeName = "int")]
        public int UserId { get; set; }
        [Column(TypeName = "int")]
        public int RoleId { get; set; }
    }
}
