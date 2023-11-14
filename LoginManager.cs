using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginÖvining
{
    public class LoginManager
    {
        private List<User> _users;
        public LoginManager()
        {
            _users = new List<User>();

            _users.Add(new User("admin", "123"));
            _users.Add(new User("bankowner", "123"));
            _users.Add(new User("user", "123"));
        }

        public bool Login(string username,string password)
        {
                foreach (User user in _users)
                {
                    if (user.Username == username && user.Password == password)
                    {
                        return true;
                    }
                }
                return false;
            
           
        }
    }
}
