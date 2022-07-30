using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class RoleModel
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Name must be less than 20 characters long")]
        public string Name { get; set; }

        
        IEnumerable<UserRoleModel> UserRoleModels { get; set; } = new List<UserRoleModel>();
    }
}
