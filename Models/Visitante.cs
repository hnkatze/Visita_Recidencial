using System.ComponentModel.DataAnnotations;

public class Visitante{
[Key]
public Guid VisistanteId{get;set;}=Guid.NewGuid();

[Required]
public int Identificador{get;set;}
[Required]
public String Nombre {get;set;}
[Required]
public int Edad{get;set;}
[Required]
public Boolean Sexo{get;set;}

public ICollection<Visita> visita{get;set;}
}