namespace LeakGas.Api.DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public long IdNivelAcesso { get; set; }

        public string Nome { get; set; }

        public long NrDocumento { get; set; }

        public long Telefone { get; set; }
    }
}
