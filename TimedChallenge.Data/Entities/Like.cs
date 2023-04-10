using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimedChallenge.Data.Entities
{
    public class Like
    {
        [Key]
        public int Id { get; set; }
        [Required]
        Guid OwnerId { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}