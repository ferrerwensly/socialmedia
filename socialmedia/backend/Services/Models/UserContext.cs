using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using backend.Services.Models.Entities;


namespace backend.Services.Models
{
    public class UserContext :DbContext
    {

      public UserContext() : base("SocialMediaDB") { }
      public IDbSet<UserAccount> userAccount { get; set; }
      public IDbSet<Comments> comments { get; set; }
      public IDbSet<FriendsList> friendList { get; set; }
      public IDbSet<Notifications> notifications { get; set; }
      public IDbSet<Register> register { get; set; }
      public IDbSet<StatusDetails> statusDetails { get; set; }


    }
}
