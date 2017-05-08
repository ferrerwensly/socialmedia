using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace backend.Services.Models.Entities
{
    public class Register
    {
        [Key]
        public int UserId { get; set; }

        [Required, StringLength(50)]
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string UserGender { get; set; }
        public string UserBday { get; set; }
    }
}
