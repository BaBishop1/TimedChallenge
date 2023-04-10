using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CommentText { get; set; }
        public Guid AuthorID { get; set; }
        public List<Reply> RepliesToComment { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
