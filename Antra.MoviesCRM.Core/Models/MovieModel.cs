using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Models
{
    public class MovieModel
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        [MaxLength(256, ErrorMessage = "Title must be less than 256 characters long")]
        public string Title { get; set; }
        public string? Overview { get; set; }
        [MaxLength(512, ErrorMessage = "Tagline must be less than 512 characters long")]
        public string? Tagline { get; set; }
        public decimal? Budget { get; set; }
        public decimal? Revenue { get; set; }
        [MaxLength(2084, ErrorMessage = "ImdbUrl must be less than 2084 characters long")]
        public string? ImdbUrl { get; set; }
        [MaxLength(2084, ErrorMessage = "TmdbUrl must be less than 2084 characters long")]
        public string? TmdbUrl { get; set; }
        [MaxLength(2084, ErrorMessage = "PosterUrl must be less than 2084 characters long")]
        public string? PosterUrl { get; set; }
        [MaxLength(2084, ErrorMessage = "BackDropUrl must be less than 2084 characters long")]
        public string? BackDropUrl { get; set; }
        [MaxLength(64, ErrorMessage = "OriginalLanguage must be less than 2084 characters long")]
        public string? OriginalLanguage { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? RunTime { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? CreatedBy { get; set; }

        public IEnumerable<CastModel> Casts { get; set; } = new List<CastModel>();
    }
}
