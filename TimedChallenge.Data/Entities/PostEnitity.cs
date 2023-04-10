using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

    public class PostEnitity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PostTitle { get; set; }
        [Required]
        public string PostText { get; set; }
        public List<Comments> CommentsOnPost { get; set; }
        public List<Likes> LikesOnPost { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
