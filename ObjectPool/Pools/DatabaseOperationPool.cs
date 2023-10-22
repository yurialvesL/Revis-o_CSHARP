using ObjectPool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool.Pools
{
    public class DatabaseOperationPool : ObjectPool<Guid, BasePoolData>
    {
        public DatabaseOperationPool(Func<BasePoolData> objectGenerator) : base(objectGenerator)
        {
        }


    }
}
