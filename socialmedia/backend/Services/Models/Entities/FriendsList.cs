using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace backend.Services.Models.Entities
{
    public class FriendsList
    {
        [Key]
        public int RecId { get; set; }

        [Required]
        public int RequestedId { get; set; }
        public int RequesterId { get; set; }


    }
}
