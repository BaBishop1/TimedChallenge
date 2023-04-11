using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimedChallenge.Data.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [ForeignKey("PostEntity")]
        public int PostId { get; set; }
        public virtual PostEntity PostEntity { get; set; }
        [Required]
        public string CommentText { get; set; }
        [Required]
        public Guid AuthorID { get; set; }
        public virtual List<Reply> RepliesToComment { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}