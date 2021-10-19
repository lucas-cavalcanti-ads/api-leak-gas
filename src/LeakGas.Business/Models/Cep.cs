using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_CEP")]
    public class Cep
    {
        [Key]
        [Column("CEP")]
        public int CepDesc { get; set; }
        [Column("FK_CIDADE")]
        public int IdCidade { get; set; }
    }
}
