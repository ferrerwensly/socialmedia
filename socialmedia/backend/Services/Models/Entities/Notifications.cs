using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace backend.Services.Models.Entities
{
    public class Notifications 
    {
        [Key]
        public int NotifId { get; set; }

        [Required]
        public string NotifContent { get; set; }
        public string NotifUserId { get; set; }


    }
}
