using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

    public class Reply
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ReplyText { get; set; }
        public Guid AuthorID { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
