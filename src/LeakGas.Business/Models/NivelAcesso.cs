using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_NIVEL_ACESSO")]
    public class NivelAcesso
    {
        [Column("ID_NIVEL_DE_ACESSO")]
        public int Id { get; set; }
        [Column("DESC_NIVEL")]
        public string Descricao { get; set; }
    }
}
