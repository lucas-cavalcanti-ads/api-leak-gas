using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_APARTAMENTO")]
    public class Apartamento
    {
        [Column("ID_APARTAMENTO")]
        public int Id { get; set; }

        [Column("FK_ID_CONDOMINIO")]
        public int IdCondominio { get; set; }

        [Column("NR_APARTAMENTO")]
        public int NrApartamento { get; set; }
        [Column("BLOCO")]

        public string Bloco { get; set; }

        public virtual IEnumerable<UsuarioApartamento> UsuariosApartamentos { get; set; }

        public virtual Condominio Condominio { get; set; }
    }
}
