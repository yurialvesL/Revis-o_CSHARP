using ObjectPool.Enums;
using ObjectPool.Pools;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool.Entities
{
    public class BasePoolData
    {
        public TableData Table { get; set; }

        public IoOperation Operation { get; set; }

        public BaseModel Data { get; set; }


    }

    public abstract class BaseModel
    {
        public int Id { get; set; }
    }
}
