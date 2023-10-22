using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool.Entities
{
    public class Concorrence 
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
     
        public Concorrence()
        {
            Id = Guid.NewGuid();
            Message = "";
        }
    }
}