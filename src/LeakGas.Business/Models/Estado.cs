using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_ESTADO")]
    public class Estado
    {
        [Column("ID_ESTADO")]
        public int Id { get; set; }
        [Column("NM_ESTADO")]
        public string Nome { get; set; }
    }
}
