namespace TrainingASPDotNet.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Database")
        {
        }

        public virtual DbSet<PencapaianProgram> PencapaianPrograms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PencapaianProgram>()
                .Property(e => e.KodProgram)
                .IsUnicode(false);

            modelBuilder.Entity<PencapaianProgram>()
                .Property(e => e.JenisKemasukan)
                .IsUnicode(false);
        }
    }
}
