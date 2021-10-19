using LeakGas.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeakGas.Data.Context
{
    public class LeakGasContext : DbContext
    {
        #region DbSets
        public DbSet<Acesso> Acesso { get; set; }
        public DbSet<Apartamento> Apartamento { get; set; }
        public DbSet<Cep> Cep { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Condominio> Condominio { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<NivelAcesso> NivelAcesso { get; set; }
        public DbSet<Notificacao> Notificacao { get; set; }
        public DbSet<Ocorrencia> Ocorrencia { get; set; }
        public DbSet<TipoOcorrencia> TipoOcorrencia { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioApartamento> UsuarioApartamento { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<ViewAlarme> ViewAlarme { get; set; }
        public DbSet<ViewUsuario> ViewUsuario { get; set; }

        #endregion
        public LeakGasContext(DbContextOptions<LeakGasContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LeakGasContext).Assembly);
        }
    }
}
