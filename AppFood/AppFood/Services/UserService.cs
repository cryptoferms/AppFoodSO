using AppFood.Model;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database.Query;

namespace AppFood.Services
{
    public class UserService
    {
        FirebaseClient client;
        public UserService()
        {
            client = new FirebaseClient("https://foodapp-d03c7-default-rtdb.firebaseio.com/");
        }
        public async Task<bool> UsuarioExiste(string username)
        {
            var user = (await client.Child("Users")
                .OnceAsync<User>()).Where(u => u.Object.Username == username).FirstOrDefault();

            return (user != null);
        }

        public async Task<bool> RegistrarUsuario(string username, string password)
        {
            if (await UsuarioExiste(username) == false)
            {
                await client.Child("Users")
                    .PostAsync(new User()
                    {
                        Username = username,
                        Password = password
                    });
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> LoginUsuario(string username, string password)
        {
            var user = (await client.Child("Users")
                .OnceAsync<User>()).Where(u => u.Object.Username == username)
                .Where(u => u.Object.Password == password).FirstOrDefault();

            return (user != null);
        }
    }
}
