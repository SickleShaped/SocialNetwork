using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("Мои друзья: ");

            if (friends.Count() == 0)
            {
                Console.WriteLine("У вас нет друзей :(");
                return;
            }

            var friendList = friends.ToList();
            
            foreach(var friend in friendList)
            {
                Console.WriteLine($"{friend.FirstName} {friend.LastName}; Адрес: {friend.Email}");
            }

        }
    }
}
