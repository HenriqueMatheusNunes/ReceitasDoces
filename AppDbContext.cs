using System;

public class Class1
{
	public Class1()
	{
	}
}


public class AppDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    // adiciona as outras duas tabelas aqui

    public DbSet<Receita> Receitas { get; set; }

    public DbSet<Ingredientes> Ingredientes { get; set; }


}
