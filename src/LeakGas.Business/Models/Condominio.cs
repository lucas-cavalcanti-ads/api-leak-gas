using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_CONDOMINIO")]
    public class Condominio
    {
        [Column("ID_CONDOMINIO")]
        public int Id { get; set; }
        [Column("FK_CEP")]
        public int Cep { get; set; }
        [Column("NM_CONDOMINIO")]
        public string Nome { get; set; }
        [Column("NM_ENDERECO")]
        public string Endereco { get; set; }
        [Column("NR_ENDERECO")]
        public int NumeroEndereco { get; set; }

        public virtual IEnumerable<Apartamento> Apartamentos { get; set; }

    }
}
