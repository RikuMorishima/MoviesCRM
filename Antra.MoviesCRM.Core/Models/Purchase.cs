﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class Purchase
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "int")]
        public int UserId { get; set; }
        [Column(TypeName = "uniqueidentifier")]
        public Guid PurchaseNumber { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        [Column(TypeName = "datetime2(7)")]
        public DateTime PurchaseDateTime { get; set; }
        [Column(TypeName = "int")]
        public int MovidId { get; set; }
    }
}
