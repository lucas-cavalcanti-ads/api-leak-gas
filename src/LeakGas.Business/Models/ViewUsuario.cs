using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("VW_USUARIO_CONDOMINIO")]
    public class ViewUsuario
    {
        [Column("ID_USUARIO")]
        public int Id { get; set; }
        [Column("NM_USUARIO")]

        public string Nome { get; set; }
        [Column("NR_DOCUMENTO")]

        public long NrDocumento { get; set; }
        [Column("NR_TELEFONE")]

        public long Telefone { get; set; }
        [Column("ID_APARTAMENTO")]
        public int IdApartamento { get; set; }

        [Column("NR_APARTAMENTO")]
        public int NrApartamento { get; set; }

        [Column("BLOCO")]

        public string Bloco { get; set; }

        [Column("ID_CONDOMINIO")]
        public int IdCondominio { get; set; }

        [Column("NM_CONDOMINIO")]
        public string NomeCondominio { get; set; }
    }
}
