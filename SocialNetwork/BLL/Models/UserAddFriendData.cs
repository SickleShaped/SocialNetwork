using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models;

public class UserAddingFriendData
{
    public int UserId { get; set; }
    public string FriendEmail { get; set; }
}
