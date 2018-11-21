using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMusic.Models
{
    public class Info
    {
        public string name { get; set; }
        public int age { get; set; }
    }
    public class tblUser
    {
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public string tblRole_Name { get; set; }

    }
}
