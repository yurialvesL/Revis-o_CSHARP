using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool.Entities
{
    public class ConcorrencePool : ObjectPool<Guid>
    {
        public int MyProperty { get; set; }
        public ConcorrencePool(): base (()=>  new ())
        
            
        }

      
    }
}
