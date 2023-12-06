using Domain.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Interfaces
{
    public interface IGeneratorService
    {
        Task<OperationResult<Cliente>> RegisterNewKey(Cliente cliente);
    }
}
