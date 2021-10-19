using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_OCORRENCIAS")]
    public class Ocorrencia
    {
        [Column("ID_OCORENCIAS")]
        public int Id { get; set; }
        [Column("FK_ID_APARTAMENTO")]

        public int IdApartamento { get; set; }
        [Column("FK_ID_TP_OCORRENCIA")]

        public int TipoOcorrencia { get; set; }
        [Column("FK_ID_NOTIFICACAO")]

        public int IdNotificacao { get; set; }

        [Column("FK_ID_STATUS")]
        public int IdStatus { get; set; }

        [Column("DT_OCORRENCIA")]

        public DateTime DataOcorrencia { get; set; }
    }
}
