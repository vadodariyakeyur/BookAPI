using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApiProject.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(200, MinimumLength = 10, ErrorMessage = "Headline must be between 10 to 200 charcters long.")]
        [Required]
        public string Headline { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 50, ErrorMessage = "Headline must be between 50 to 2000 charcters long.")]
        public string ReviewText { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Rating muist be in between 1 and 5 stars")]
        public int Rating { get; set; }

        public virtual Reviewer Reviewer { get; set; }
        public virtual Book Book { get; set; }

    }
}
