using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models.Models
{
    public class Cliente
    {
        public int idCliente { get; set; }
        [JsonPropertyName("Nome")]
        public string xNome { get; set; }
        [JsonPropertyName("Telefone")]
        public string xTelefone { get; set; }
        [JsonPropertyName("CPF")]
        public string xCPF { get; set; }
        [JsonPropertyName("E-mail")]
        public string xEmail { get; set; }
        [JsonPropertyName("NumeroGerado")]
        public int xNumeroGerado { get; set; }
    }
}
