using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Entities
{
    public class User: IdentityUser
    {
        [Column(TypeName = "nvarchar(128)")]
        public string? FirstName { get; set; }
        [Column(TypeName = "nvarchar(128)")]
        public string? LastName { get; set; }
        //[Column(TypeName ="datetime2(7)")]
        //public DateTime? DateOfBirth { get; set; }

        //[Column(TypeName = "nvarchar(1024)")]
        //public string? Salt { get; set; }

        //[Column(TypeName = "datetime2(7)")]
        //public DateTime? LockoutEndDate { get; set; }
        //[Column(TypeName = "datetime2(7)")]
        //public DateTime? LastLoginDateTime { get; set; }
        //[Column(TypeName = "bit")]
        //public bool? IsLocked { get; set; }


        // Navigation Properties
        public IEnumerable<Review> ReviewsRef { get; set; }
        public IEnumerable<Purchase> PurchasesRef { get; set; }
        public IEnumerable<Favorite> FavoritesRef { get; set; }
    }
}
