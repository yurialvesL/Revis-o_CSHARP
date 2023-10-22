using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool.Entities
{
    public class Maintenance
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public Guid VehicleId { get; set; }

        public Guid UserId { get; set; }
    }
}
