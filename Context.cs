using Microsoft.EntityFrameworkCore;


public class Context:DbContext {
public DbSet<Casa> Casas{get;set;}
public DbSet<Visita> Visitas{get;set;}
public DbSet<Visitante> Visitantes {get;set;}
public DbSet<Residente> Residentes {get;set;}
public DbSet<HabitantesC> HabitantesCs {get;set;}

public Context(DbContextOptions<Context> options) : base(options){}

}