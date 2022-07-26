using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameLibrary.Models
{
    public class Games
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        
        [MaxLength(300)]
        public string Description { get; set; }
        
        public DateTime? ReleaseDate { get; set; }
        
        public bool Released { get; set; }
        
        [Required]
        [MaxLength(80)]
        public string Developer { get; set; }
        
        [Required]
        [MaxLength(120)]
        public string Platforms { get; set; }
    }
}