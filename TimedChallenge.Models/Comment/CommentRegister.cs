using System.ComponentModel.DataAnnotations;


public class CommentRegister
    {
        [Required]
        public string CommentText { get; set; }
    }
