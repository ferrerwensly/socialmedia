using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace backend.Services.Models.Entities
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public int StatusId { get; set; }
        public int CommentContent { get; set; }



    }
}
