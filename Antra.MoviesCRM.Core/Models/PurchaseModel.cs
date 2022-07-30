using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class PurchaseModel
    {

        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public Guid PurchaseNumber { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public DateTime PurchaseDateTime { get; set; }
        [Required]
        public int MovidId { get; set; }
    }
}
