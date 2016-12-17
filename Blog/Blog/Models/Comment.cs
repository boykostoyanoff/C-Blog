using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        public string Content { get; set; }

        public string AuthorId { get; set; }

        public int ArticleId { get; set; }
    }
}