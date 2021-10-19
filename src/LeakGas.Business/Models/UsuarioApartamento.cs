using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_USU_AP")]
    public class UsuarioApartamento
    {
        [Column("ID_USU_AP")]
        public int Id { get; set; }
        [Column("FK_ID_USUARIO")]

        public int IdUsuario { get; set; }

        [Column("FK_ID_APARTAMENTO")]

        public int IdApartamento { get; set; }

        public virtual Apartamento Apartamento { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
