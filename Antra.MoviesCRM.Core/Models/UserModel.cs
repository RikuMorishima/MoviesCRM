using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class UserModel
    {

        public int Id { get; set; }
        [MaxLength(128, ErrorMessage = "FirstName must be less than 128 characters long")]
        public string? FirstName { get; set; }
        [MaxLength(128, ErrorMessage = "LastName must be less than 128 characters long")]
        public string? LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }
        [MaxLength(256, ErrorMessage = "Email must be less than 256 characters long")]
        public string? Email { get; set; }
        [MaxLength(1024, ErrorMessage = "HashedPassword must be less than 1024 characters long")]
        public string? HashedPassword { get; set; }
        [MaxLength(1024, ErrorMessage = "Salt must be less than 1024 characters long")]
        public string? Salt { get; set; }
        [MaxLength(16, ErrorMessage = "PhoneNumber must be less than 16 characters long")]
        public string? PhoneNumber { get; set; }

        public bool? TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDate { get; set; }

        public DateTime? LastLoginDateTime { get; set; }

        public bool? IsLocked { get; set; }

        public int? AccessFailedCount { get; set; }

        IEnumerable<UserRoleModel> Roles { get; set; } = new List<UserRoleModel>();
        IEnumerable<PurchaseModel> Purchases { get; set; } = new List<PurchaseModel>();
        IEnumerable<FavoriteModel> Favorites { get; set; } = new List<FavoriteModel>();
        IEnumerable<ReviewModel> Reviews { get; set; } = new List<ReviewModel>();

    }
}
