using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMusic.Services
{
    public class Database
    {
        public static string ConnnectionString = "mongodb://gfs23jsi32y:fwN6wXvtMNvYV51M@cluster0-shard-00-00-gewym.mongodb.net:27017,cluster0-shard-00-01-gewym.mongodb.net:27017,cluster0-shard-00-02-gewym.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin&retryWrites=true";
        public static string Name => "cmusic";
    }
}
