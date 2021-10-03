using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bdeneme.Service
{
    public class UserService
    {
        public static List<string> UserList= new List<string>{"menan","kenan","recep","furkan","saffet"};

        public ValueTask<string> GetTaskAsync(string name)
        {
            return new ValueTask<string> (UserList.Find(p=> p == name));
        }
    }
}