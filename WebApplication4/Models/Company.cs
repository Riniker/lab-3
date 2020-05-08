using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public int WorkerCount { get; set; }
    }
}
