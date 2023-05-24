using System.ComponentModel.DataAnnotations;

public class Residente{
[Key]
public Guid ResidenteId{get;set;} = Guid.NewGuid();

[Required]
public int Identificador{get;set;}

[Required]
public String Nombre {get;set;}

[Required]
public int Telefono{get;set;}


}