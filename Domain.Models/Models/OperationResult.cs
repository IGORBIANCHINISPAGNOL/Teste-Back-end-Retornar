using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models.Models
{
    public class OperationResult<T> where T : class
    {
        public OperationResult(bool bSucess, string? xMesageError = null) {         
            this.bSucess = bSucess;
            this.xMesageError = xMesageError;      
        }
        [JsonPropertyName("bSucesso")]
        public bool bSucess { get; set; }
        [JsonPropertyName("MensagemErro")]
        public string? xMesageError { get; set; }
        [JsonPropertyName("ClienteModel")]
        public T? ClientModel { get; set; }
    }
}
