using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMusic.Services
{
    public class HelloService : IHelloService
    {
        public string Hello(string name)
        {
            return $"Hello {name}";
        }
    }
}
