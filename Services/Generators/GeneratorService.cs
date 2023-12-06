using Data.DatabaseModels;
using Domain.Models.Interfaces;
using Domain.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Generators
{
    public class GeneratorService : IGeneratorService
    {
        public readonly IGeneratorRepository _generatorRepository;
        public GeneratorService(IGeneratorRepository generatorRepository) => _generatorRepository = generatorRepository;
     
        public async Task<OperationResult<Cliente>> RegisterNewKey(Cliente cliente)
        {
            try
            {
                cliente = await _generatorRepository.GetPostClient(cliente);                                        
                cliente.xNumeroGerado = GenerateNewKey(await _generatorRepository.GetAllNumbers());
                SaveTxt(cliente);
                return new OperationResult<Cliente>(_generatorRepository.PostNewKey(cliente))
                {
                    ClientModel = cliente,
                };
            }
            catch (Exception ex)
            {
                return new OperationResult<Cliente>(false, ex.Message);
            }            
        }
        private async void SaveTxt(Cliente cliente) => await System.IO.File.AppendAllTextAsync($"C:\\Generator\\{cliente.xEmail.ToUpper()}.txt", $"{cliente.xNumeroGerado.ToString()}\r");           
        
        private int GenerateNewKey(List<int> _lNumerosGerados)
        {
            int _result = 0;
            int count = 0;
            Random randNum = new Random();
            while (true)
            {
                count++;
                _result = randNum.Next(1, 99999);
                if (_lNumerosGerados.Where(x => x == _result).FirstOrDefault() == 0)
                    return _result;

                if (count > 199999)
                    throw new NotImplementedException("Numeros esgotados");
            }
        }
    }
}
