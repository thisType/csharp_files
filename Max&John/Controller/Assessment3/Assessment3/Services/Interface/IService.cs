using Assessment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3.Services.Interface
{
    public interface IService
    {

         

         Task<List<Post>> GetPosts();
        

        Task<List<Comment>> GetComments();




    }
}
