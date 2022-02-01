using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1.Persistance.DbServices
{
    public interface IMachineDbService
    {
        Task AddAsync();
        Task RemoveAsync();

        Task GetAsync();

        Task ConnectedAsync();
        Task DisconnectedAsync();
    }
}