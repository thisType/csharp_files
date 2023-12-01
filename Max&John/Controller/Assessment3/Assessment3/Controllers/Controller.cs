using Assessment3.Models;
using Assessment3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3.Controllers
{
    public class Controller
    {


        public void ListUsers()
        {
            Service service = new Service();

            Task<List<User>> ListUsers = service.GetAllUsers();

            List<User> users = ListUsers.Result;
              
            foreach (User user in users)
            {

                Console.WriteLine($"{user.id}, {user.name} ,{user.username}, {user.email}");



            }

            Console.WriteLine("UserId: ");

            string userid = Console.ReadLine();

            DisplayPostByUserId(Convert.ToInt32(userid));



        }


        public void DisplayPostByUserId(int userId)
        {

            Service service = new Service();

            Task<List<Post>> posts = service.GetPosts();

            foreach (Post post in posts.Result)
            {

                if(post.userId == userId)
                {

                    Console.WriteLine($"id:{post.id}\ntitle:{post.title} \n body:{post.body} \n\n");                          
}


                }

            Console.WriteLine("Enter PostId: ");

                string postid = Console.ReadLine();

                   DisplayCommentsByPostId(Convert.ToInt32(postid));


            }



        public void DisplayCommentsByPostId(int postId)
        {   

            Service servie = new Service();
            Console.WriteLine("Comments:");
            Task<List<Comment>> comments = servie.GetComments();

            foreach (Comment comment in comments.Result)
            {
                if(comment.postId == postId)
                {
                    Console.WriteLine($"name:{comment.name}\n email:{comment.email}\n body:{comment.body}\n\n");             
                }
            }
        }





        }



    }

