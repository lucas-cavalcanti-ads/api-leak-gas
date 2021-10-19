using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_CIDADE")]
    public class Cidade
    {
        [Column("ID_CIDADE")]
        public int Id { get; set; }
        [Column("FK_ESTADO")]
        public int IdEstado { get; set; }
        [Column("NM_CIDADE")]
        public string Nome { get; set; }
    }
}
