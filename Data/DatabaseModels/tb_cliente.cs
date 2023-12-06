using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DatabaseModels
{
    [Table("tb_cliente")]
    public class tb_cliente
    {
        [Key]
        public int idCliente { get; set; }
        public string xNomeCliente { get; set; }
        public string xTelefone { get; set; }
        public string xCPF { get; set; }
        public string xEmail { get; set; }
    }
}
