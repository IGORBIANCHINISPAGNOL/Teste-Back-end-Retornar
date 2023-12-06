using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DatabaseModels
{
    [Table("tb_numerosGerados")]
    public class tb_numerosGerados
    {
        [Key]
        public int idNumeroGerado { get; set; }
        public int xNumeroGerado { get; set; }
        public int idCliente { get; set; }
        [ForeignKey(name: "idCliente")]
        public virtual tb_cliente? tb_cliente { get; set; }
    }
}
