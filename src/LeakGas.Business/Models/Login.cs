using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_LOGIN")]
    public class Login
    {
        [Key]
        [Column("LOGIN")]
        public string Usuario { get; set; }
        [Column("SENHA")]
        public string Senha { get; set; }
        [Column("FK_ID_USUARIO")]
        public int IdUsuario { get; set; }
    }
}
