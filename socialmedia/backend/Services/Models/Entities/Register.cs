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

        [Required(ErrorMessage ="EmailAddress is required"), StringLength(50)]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Username is required"), StringLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required"), StringLength(50)]
        [DataType(DataType.Password)]
        public string UserPass { get; set; }

        [Required(ErrorMessage = "Gender is required"), StringLength(50)]
        public string UserGender { get; set; }

        [Required(ErrorMessage = "Birthday is required"), StringLength(50)]
        public string UserBday { get; set; }
    }
}
