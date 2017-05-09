using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace backend.Services.Models.Entities
{
    public class StatusDetails
    {
        [Key]
        public int StatusId { get; set; }

        public int UserId { get; set; }

        [Required,StringLength(250)]
        public string StatusContent { get; set; }
        public int StatusLike { get; set; }
        public int StatusDislike { get; set; }


    }
}
