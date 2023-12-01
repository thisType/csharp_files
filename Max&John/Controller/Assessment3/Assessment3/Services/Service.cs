using Assessment3.Models;
using Assessment3.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assessment3.Services
{
     class Service : IService
    {


        public async Task<List<User>> GetAllUsers() {

            HttpClient client = new HttpClient();


            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
              response.EnsureSuccessStatusCode();
              var stream = await response.Content.ReadAsStreamAsync();

            List<User> users = await JsonSerializer.DeserializeAsync<List<User>>(stream);

            return users;
  }
        

        public async Task<List<Post>> GetPosts()
        {
                   HttpClient client = new HttpClient();


            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts ");
            response.EnsureSuccessStatusCode();
            var stream = await response.Content.ReadAsStreamAsync();

            List<Post> posts = await JsonSerializer.DeserializeAsync<List<Post>>(stream);

            return posts;

        }


        public async Task<List<Comment>> GetComments()
        {


            HttpClient client = new HttpClient();


            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/comments");
            response.EnsureSuccessStatusCode();
            var stream = await response.Content.ReadAsStreamAsync();

            List<Comment> comments = await JsonSerializer.DeserializeAsync<List<Comment>>(stream);

            return comments;


        }

    }
}
