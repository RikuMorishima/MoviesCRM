using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Entities
{
    public class User
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(128)")]
        public string? FirstName { get; set; }
        [Column(TypeName = "nvarchar(128)")]
        public string? LastName { get; set; }
        [Column(TypeName ="datetime2(7)")]
        public DateTime? DateOfBirth { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string? Email { get; set; }
        [Column(TypeName = "nvarchar(1024)")]
        public string? HashedPassword { get; set; }
        [Column(TypeName = "nvarchar(1024)")]
        public string? Salt { get; set; }
        [Column(TypeName = "nvarchar(16)")]
        public string? PhoneNumber { get; set; }
        [Column(TypeName = "bit")]
        public bool? TwoFactorEnabled { get; set; }
        [Column(TypeName = "datetime2(7)")]
        public DateTime? LockoutEndDate { get; set; }
        [Column(TypeName = "datetime2(7)")]
        public DateTime? LastLoginDateTime { get; set; }
        [Column(TypeName = "bit")]
        public bool? IsLocked { get; set; }
        [Column(TypeName = "int")]
        public int? AccessFailedCount { get; set; }

    }
}
