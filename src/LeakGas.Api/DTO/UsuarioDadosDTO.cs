namespace LeakGas.Api.DTO
{
    public class UsuarioDadosDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public long NrDocumento { get; set; }

        public long Telefone { get; set; }
        public int IdApartamento { get; set; }

        public int NrApartamento { get; set; }

        public string Bloco { get; set; }
        public int IdCondominio { get; set; }
        public string NomeCondominio { get; set; }
    }
}
