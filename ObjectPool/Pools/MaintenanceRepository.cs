using ObjectPool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool.Pools
{
    public class MaintenanceRepository
    {
        private DatabaseOperationPool databasePool;
        public MaintenanceRepository(DatabaseOperationPool databasePool)
        {
            this.databasePool = databasePool;
        }

        public Task Create(ManutencaoModel model)
        {
            databasePool.AdicionarAtualizar(Guid.NewGuid(), new BasePoolData()
            {
                Table = Enums.TableData.Maintenance,
                Operation = Enums.IoOperation.Create,
                Data = model
            });

            return Task.CompletedTask;
        }

        public Task Delete(ManutencaoModel model)
        {
            databasePool.AdicionarAtualizar(Guid.NewGuid(), new BasePoolData()
            {
                Table = Enums.TableData.Maintenance,
                Operation = Enums.IoOperation.Delete,
                Data = model
            });
            return Task.CompletedTask;
        }

        public Task Update(ManutencaoModel model)
        {
            databasePool.AdicionarAtualizar(Guid.NewGuid(), new BasePoolData()
            {
                Table = Enums.TableData.Maintenance,
                Operation = Enums.IoOperation.Update,
                Data = model
            });

            return Task.CompletedTask;
        }

    }

    public class ManutencaoModel : BaseModel
    {
        public string ManutencaoCode { get; set; }

    }
}
