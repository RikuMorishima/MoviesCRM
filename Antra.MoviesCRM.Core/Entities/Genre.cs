﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Entities
{
    public class Genre
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(64)")]
        public string Name { get; set; }

        //Navigation Properties
        public IEnumerable<MovieGenre> MovieGenresRef { get; set; }
    }
}
