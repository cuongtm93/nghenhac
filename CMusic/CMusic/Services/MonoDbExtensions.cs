using CMusic.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMusic.Services
{
    public static class MonoDbExtensions
    {
        public static IMongoCollection<T> Table<T>(this IMongoDatabase database)
        {
            var type = typeof(T).Name;
            return database.GetCollection<T>(type);
        }
    }
}
