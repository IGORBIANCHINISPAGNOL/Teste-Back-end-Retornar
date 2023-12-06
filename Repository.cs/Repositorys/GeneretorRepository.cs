using Data.Context;
using Data.DatabaseModels;
using Domain.Models.Interfaces;
using Domain.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Repository.Repositorys
{
    public class GeneretorRepository : IGeneratorRepository
    {
        private readonly Contexts _context;
        public GeneretorRepository(Contexts context) => _context = context;
        public async Task<List<int>> GetAllNumbers() => await _context.tb_numerosGerados.Select(x => x.xNumeroGerado).ToListAsync();
        public async Task<Cliente> GetPostClient(Cliente cliente)
        {
            var _client = await _context.tb_cliente.Where(x => x.xEmail == cliente.xEmail)
                .FirstOrDefaultAsync() ?? Convert(cliente);

            if (_client.xNomeCliente != cliente.xNome || _client.xCPF != cliente.xCPF || _client.xTelefone != cliente.xTelefone)
                throw new NotImplementedException($"Cliente já cadastrado com o E-mail: {_client.xEmail}");

            if (_client.idCliente == 0)
            {
                _context.tb_cliente.Add(_client);
                _context.SaveChanges();
            }            
            return Convert(_client);
        }
        public bool PostNewKey(Cliente cliente)
        {
            _context.tb_numerosGerados.Add(ConvertKey(cliente));
            _context.SaveChanges();
            return true;
        }
        private tb_numerosGerados ConvertKey(Cliente c)
        {
            return new tb_numerosGerados
            {
                idCliente = c.idCliente,
                xNumeroGerado = c.xNumeroGerado,           
            };
        }
        private Cliente Convert(tb_cliente c)
        {
            return new Cliente
            {
                idCliente = c.idCliente,
                xNome = c.xNomeCliente,
                xCPF = c.xCPF,
                xTelefone = c.xTelefone,
                xEmail = c.xEmail,
            };
        }
        private tb_cliente Convert(Cliente c)
        {
            return new tb_cliente
            {
                idCliente = c.idCliente,
                xNomeCliente = c.xNome,
                xCPF = c.xCPF,
                xTelefone = c.xTelefone,
                xEmail = c.xEmail,
            };
        }
    }
}
