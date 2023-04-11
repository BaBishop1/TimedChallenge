using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TimedChallenge.Data.Entities;

namespace TimedChallenge.Data.Entities
{
    public class PostEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PostTitle { get; set; }
        [Required]
        public string PostText { get; set; }
        public virtual List<Comment> CommentsOnPost { get; set; }
        public virtual List<Like> LikesOnPost { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}