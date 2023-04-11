using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimedChallenge.Data.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string CommentText { get; set; }
        public Guid AuthorID { get; set; }
        public virtual List<Reply> RepliesToComment { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}