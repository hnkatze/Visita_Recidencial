using System.ComponentModel.DataAnnotations;

public class Residente{
[Key]
public Guid ResidenteId{get;set;}

[Required]
public int Identificador{get;set;}
[Required]
public String Nombre {get;set;}
[Required]
public int Telegono{get;set;}



}