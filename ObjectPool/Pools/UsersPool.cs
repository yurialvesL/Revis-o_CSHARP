using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectPool.Entities;

namespace ObjectPool.Pools
{
    public class UsersPool : ObjectPool<Guid, Users>
    {

        public UsersPool() : base(() => new Users())
        {

        }

     

    }
}
