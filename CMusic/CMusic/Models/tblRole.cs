using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMusic.Models
{
    public class tblRole
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
