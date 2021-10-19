using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_ACESSOS")]
    public class Acesso
    {
        [Column("ID_ACESSO")]
        public int Id { get; set; }
        [Column("FK_ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Column("DT_ACESSO")]
        public DateTime DataAcesso { get; set; }
    }
}
