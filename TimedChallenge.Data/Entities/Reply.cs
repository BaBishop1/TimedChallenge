using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimedChallenge.Data.Entities
{
    public class Reply
    {
        [Key]
        public int ReplyId { get; set; }
        [ForeignKey("Comment")]
        public int CommentId { get; set; }
        public virtual Comment CommentEntity { get; set; }
        [Required]
        public string ReplyText { get; set; }
        [Required]
        public Guid AuthorID { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}