using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class UserRoleModel
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        IEnumerable<RoleModel> Roles { get; set; } = new List<RoleModel>();
        IEnumerable<UserModel> Users { get; set; } = new List<UserModel>();
    }
}
