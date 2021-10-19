using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Keyless]
    [Table("VW_ALARME")]
    public class ViewAlarme
    {
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("ID_CONDOMINIO")]
        public int IdCondominio { get; set; }
        [Column("NM_CONDOMINIO")]
        public string NomeCondominio { get; set; }
        [Column("ID_APARTAMENTO")]
        public int IdApartamento { get; set; }

        [Column("NR_APARTAMENTO")]
        public int NrApartamento { get; set; }
        [Column("BLOCO")]

        public string Bloco { get; set; }
        [Column("DESC_STATUS")]
        public string DescricaoStatus { get; set; }
        [Column("DT_OCORRENCIA")]

        public DateTime DataOcorrencia { get; set; }
    }
}
