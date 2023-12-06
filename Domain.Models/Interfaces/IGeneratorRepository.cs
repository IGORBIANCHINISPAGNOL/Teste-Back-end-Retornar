using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Models;

namespace Domain.Models.Interfaces
{
    public interface IGeneratorRepository
    {
        Task<List<int>> GetAllNumbers();
        Task<Cliente> GetPostClient(Cliente xEmail);
        bool PostNewKey(Cliente cliente);
  
    }
}
