using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_NOTIFICACAO")]
    public class Notificacao
    {
        [Column("ID_NOTIFICACAO")]
        public int Id { get; set; }
        [Column("DESC_NOTIFICACAO")]
        public string Descricao { get; set; }
    }
}
