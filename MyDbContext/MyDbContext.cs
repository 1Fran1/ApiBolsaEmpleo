namespace ApiBolsaEmpleo.MyDbContext
{
	using Microsoft.EntityFrameworkCore;

	public class MyDbContext : DbContext
	{
		//Sirve para ...
		public MyApiContext(DbContextOptions<MyApiContext> options)
		  : base(options)
		{

		}
		public DbSet<Candidato> candidato { get; set; }
		public DbSet<Habilidad> habilidad { get; set; }
		public DbSet<Candidato_Habilidad> Candidato { get; set; }

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	// Configurar la base de datos en memoria
		//	optionsBuilder.UseInMemoryDatabase("MyProjectDB");


            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // uno a muchos

            //modelBuilder.Entity<Formacion>()
            //.HasOne(formacion => formacion.Candidato)
            //.WithMany(candidato => candidato.formaciones)
            //.HasForeignKey(k => k.CandidatoId);

            //modelBuilder.Entity<Oferta>()
            //.HasOne(oferta => oferta.Empresa)
            //.WithMany(empresa => empresa.ofertas)
            //.HasForeignKey(k => k.EmpresaId);


            // muchos a muchos

            // CandidatoHabilidad

            modelBuilder.Entity<CandidatoHabilidad>()
            .HasKey(ch => new { ch.CandidatoId, ch.HabilidadId });

            modelBuilder.Entity<CandidatoHabilidad>()
                .HasOne(ch => ch.Candidato)//cada candidato...
                .WithMany(c => c.CandidatoHabilidades)//puede tener muchos...
                .HasForeignKey(ch => ch.CandidatoId);//usando la llaveforanea...

            modelBuilder.Entity<CandidatoHabilidad>()//en la tabla...
                .HasOne(ch => ch.Habilidad)//cada habilidad...
                .WithMany(h => h.CandidatoHabilidades)
                .HasForeignKey(ch => ch.HabilidadId);

            // OfertaHabilidad

            //modelBuilder.Entity<OfertaHabilidad>()
            //.HasKey(ch => new { ch.OfertaId, ch.HabilidadId });

            //modelBuilder.Entity<OfertaHabilidad>()
            //    .HasOne(ch => ch.Oferta)
            //    .WithMany(c => c.OfertaHabilidades)
            //    .HasForeignKey(ch => ch.OfertaId);

            //modelBuilder.Entity<OfertaHabilidad>()
            //    .HasOne(ch => ch.Habilidad)
            //    .WithMany(h => h.OfertaHabilidades)
            //    .HasForeignKey(ch => ch.HabilidadId);

            // CandidatoOferta

            //modelBuilder.Entity<CandidatoOferta>()
            //.HasKey(ch => new { ch.CandidatoId, ch.OfertaId });

            //modelBuilder.Entity<CandidatoOferta>()
            //    .HasOne(ch => ch.Candidato)
            //    .WithMany(c => c.CandidatoOfertas)
            //    .HasForeignKey(ch => ch.CandidatoId);

            //modelBuilder.Entity<CandidatoOferta>()
            //    .HasOne(ch => ch.Oferta)
            //    .WithMany(h => h.CandidatoOfertas)
            //    .HasForeignKey(ch => ch.CandidatoId);




        }
    }
	}

}
