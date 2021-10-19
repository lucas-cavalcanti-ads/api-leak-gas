using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_STATUS")]
    public class Status
    {
        [Column("ID_STATUS")]
        public int Id { get; set; }
        [Column("DESC_STATUS")]
        public string Descricao { get; set; }
    }
}
