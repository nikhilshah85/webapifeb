using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //we need to program the methods here
        //Get, Put, Post, Delete
        [Route("greet")]
        public string GetGreetings()
        {
            return "Hello and Welcome to WebAPI"; //this output will be given to the user
                                            //in XML or JSON, based on what user requested for
        }
        [Route("greetguest")]
        public string GetGreetings(string guestName)
        {
            return "Hello and Welcome to WebAPI" + guestName;
        }

        [Route("friends")]
        public List<string> GetFriendsList()
        {
            //this values will come from database, Model will get them from database
            List<string> friends = new List<string>();
            friends.Add("Akshay");
            friends.Add("Jitesh");
            friends.Add("Karan");
            friends.Add("Piyush");
            friends.Add("Rohan");
            friends.Add("Mohan");
            friends.Add("Sohan");

            return friends;
        }

        [Route("add")]
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }



    }
}