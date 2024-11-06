using Microsoft.EntityFrameworkCore;

public class FeedbackContext : DbContext
    {
        public DbSet<Feedback> Feedbacks { get; set; }
        public string conexao = "Server=localhost;Database=Feedbacks;User=root;Password=root;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aqui você pode configurar aspectos adicionais do modelo, se necessário.
            modelBuilder.Entity<Feedback>().ToTable("feedback");
        }
    }