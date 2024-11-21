using Microsoft.EntityFrameworkCore;

namespace EscolaMusica.Data
{
    public class EscolaDbContext : DbContext
    {
        public EscolaDbContext(DbContextOptions<EscolaDbContext> options) : base(options)
        {
        }

        public DbSet<DimInstrumento> DimInstrumentos { get; set; }
        public DbSet<DimAluno> DimAlunos { get; set; }
        public DbSet<DimTempo> DimTempos { get; set; }
        public DbSet<DimAdministrador> DimAdministradores { get; set; }
        public DbSet<DimProfessor> DimProfessores { get; set; }
        public DbSet<DimTurma> DimTurmas { get; set; }
        public DbSet<DimEstoque> DimEstoques { get; set; }
        public DbSet<FatoEmprestimo> FatoEmprestimos { get; set; }
        public DbSet<FatoAgendamentoAula> FatoAgendamentosAula { get; set; }
        public DbSet<FatoMatricula> FatoMatriculas { get; set; }
        public DbSet<FatoEstoqueMovimentacao> FatoEstoquesMovimentacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FatoEmprestimo>()
                .HasOne<DimInstrumento>()
                .WithMany()
                .HasForeignKey(f => f.codigo_instrumento);

            modelBuilder.Entity<FatoEmprestimo>()
                .HasOne<DimAluno>()
                .WithMany()
                .HasForeignKey(f => f.codigo_aluno);

            modelBuilder.Entity<FatoEmprestimo>()
                .HasOne<DimTempo>()
                .WithMany()
                .HasForeignKey(f => f.codigo_tempo_emprestimo);

            modelBuilder.Entity<FatoEmprestimo>()
                .HasOne<DimTempo>()
                .WithMany()
                .HasForeignKey(f => f.codigo_tempo_devolucao);

            modelBuilder.Entity<FatoEmprestimo>()
                .HasOne<DimAdministrador>()
                .WithMany()
                .HasForeignKey(f => f.codigo_administrador);

            modelBuilder.Entity<FatoAgendamentoAula>()
                .HasOne<DimTurma>()
                .WithMany()
                .HasForeignKey(f => f.codigo_turma);

            modelBuilder.Entity<FatoAgendamentoAula>()
                .HasOne<DimProfessor>()
                .WithMany()
                .HasForeignKey(f => f.codigo_professor);

            modelBuilder.Entity<FatoAgendamentoAula>()
                .HasOne<DimTempo>()
                .WithMany()
                .HasForeignKey(f => f.codigo_tempo);

            modelBuilder.Entity<FatoAgendamentoAula>()
                .HasOne<DimAdministrador>()
                .WithMany()
                .HasForeignKey(f => f.codigo_administrador);

            modelBuilder.Entity<FatoMatricula>()
                .HasOne<DimAluno>()
                .WithMany()
                .HasForeignKey(f => f.codigo_aluno);

            modelBuilder.Entity<FatoMatricula>()
                .HasOne<DimTurma>()
                .WithMany()
                .HasForeignKey(f => f.codigo_turma);

            modelBuilder.Entity<FatoMatricula>()
                .HasOne<DimAdministrador>()
                .WithMany()
                .HasForeignKey(f => f.codigo_administrador);

            modelBuilder.Entity<FatoEstoqueMovimentacao>()
                .HasOne<DimEstoque>()
                .WithMany()
                .HasForeignKey(f => f.codigo_estoque);

            modelBuilder.Entity<FatoEstoqueMovimentacao>()
                .HasOne<DimTempo>()
                .WithMany()
                .HasForeignKey(f => f.codigo_tempo);

            modelBuilder.Entity<FatoEstoqueMovimentacao>()
                .HasOne<DimAdministrador>()
                .WithMany()
                .HasForeignKey(f => f.codigo_administrador);
        }
    }
}