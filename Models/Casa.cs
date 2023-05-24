
using System.ComponentModel.DataAnnotations;

public class Casa{
[Key]
public Guid CasaId{get;set;}

[Required]
public int Numero{get;set;}
[Required]
public int Bloque {get;set;}
[Required]
public int Calle{get;set;}
[Required]
public String Referencia{get;set;}


}