using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Max_John.Services
{
    internal class RegisterLogin : Iservice.IUser
    {


        HttpClient client = new HttpClient();


        public async Task<bool> TryRegister(UserModel user)
        {



            string user_json = JsonSerializer.Serialize<UserModel>(user);

            var content = new StringContent(user_json, Encoding.UTF8, "application/json");


            var response = await client.PostAsync("http://localhost:3000/users", content);



            response.EnsureSuccessStatusCode();

            return true;
        }





        public async Task<UserModel[]> RegisteredUsers()
        {


            HttpResponseMessage response = await client.GetAsync("http://localhost:3000/users");
            response.EnsureSuccessStatusCode();
            var stream = await response.Content.ReadAsStreamAsync();

            UserModel[] users = await JsonSerializer.DeserializeAsync<UserModel[]>(stream);
            return users;




        }
    }
}