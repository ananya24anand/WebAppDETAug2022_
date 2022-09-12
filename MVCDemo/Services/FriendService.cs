using MVCDemo.Models;
using System.Xml.Linq;

namespace MVCDemo.Services
{
    public class FriendService
    {
        static List<Friend> Friends { get; }
        static int nextId = 3;
        static FriendService()
        {
            Friends = new List<Friend>
                {
                    new Friend { FriendID = 1, FriendName = "Sara", Place="Bangalore"},
                    new Friend { FriendID = 2, FriendName = "Harry", Place="Bangalore"}
                };
        }

        public static List<Friend> GetAll() => Friends;

        public static Friend? Get(int id) => Friends.FirstOrDefault(p => p.FriendID == id);

        public static void Add(Friend friend)
        {
            friend.FriendID = nextId++;
            Friends.Add(friend);
        }

        public static void Delete(int id)
        {
            var friend = Get(id);
            if (friend is null)
                return;

            Friends.Remove(friend);
        }


        public static void Update(Friend friend)
        {
            var index = Friends.FindIndex(p => p.FriendID == friend.FriendID);
            if (index == -1)
                return;

            Friends[index] = friend;
        }
    }
}

