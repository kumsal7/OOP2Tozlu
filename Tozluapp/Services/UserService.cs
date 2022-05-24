using System;
using System.Threading.Tasks;
using Firebase.Database;
using Tozluapp.Model;
using System.Linq;


namespace Tozluapp.Services
{
    public class UserService
    {
        FirebaseClient client;
        public UserService()
        {
            client = new FirebaseClient("https://tozluapp-default-rtdb.firebaseio.com/");
        }
        public async Task<bool> IsUserExists(string uname)
        {
            var user = (await client.Child("Users")
                .OnceAsync<User>()).Where(u => u.Object.Username == uname).FirstOrDefault();
            return (user != null);
        }
    }
}
