using System;

namespace LeakGas.Api.DTO
{
    public class OcorrenciasDTO
    {
        public int IdUsuario { get; set; }
        public int IdCondominio { get; set; }
        public string NomeCondominio { get; set; }
        public int IdApartamento { get; set; }
        public int NrApartamento { get; set; }
        public string Bloco { get; set; }
        public string DescricaoStatus { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataOcorrencia { get; set; }
    }
}
