using Microsoft.Extensions.Hosting;
using ObjectPool.Entities;
using ObjectPool.Enums;
using ObjectPool.Pools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObjectPool
{
    public class PoolConsumer : BackgroundService
    {
        private readonly DatabaseOperationPool _pool;
        public PoolConsumer(DatabaseOperationPool databaseOperationPool)
        {
            this._pool = databaseOperationPool;
        }


        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Task.Run(() =>
               Task.WhenAll(
                     StartConsumer()
               ));
            return Task.CompletedTask;
        }


        private async Task StartConsumer()
        {
            ///Aqui voce precisa por uma função que fica rodando e consumindo(mas nao pode travar o background Service)
            while (true)
            {
                var data = _pool.PrimeiroOuDefault();
                if (data.Key != Guid.Empty)
                {
                    await ProccessData(data.Value);
                }
                _pool.Remover(data.Key);
                await Task.Delay(500);
            }
        }


        public async Task RunMaintenanceOperations(BasePoolData model)
        {
            // Efetua a operação da manutenção
            var data = (ManutencaoModel)model.Data;
            switch (model.Operation)
            {
                case IoOperation.Create:
                    //Aqui voce faz a operação de criação na manutenção
                    break;
            }
            await Task.Delay(100);
        }


        public async Task  ProccessData(BasePoolData data)
        {
            switch (data.Table)
            {
                case TableData.Maintenance:
                    await RunMaintenanceOperations(data);
                    break;
                default:
                    break;
            }
        }
    }
}
