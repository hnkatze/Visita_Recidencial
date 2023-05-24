using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Visita{
[Key]
public Guid VisitaId{get;set;}=Guid.NewGuid();

[Required]
public String FechaE{get;set;}
[Required]
public String FechaS {get;set;}
[ForeignKey("CasaId")]
public Guid CasaId{get;set;}
[ForeignKey("VisitanteId")]
public Guid VisitanteId{get;set;}
[Required]
public String QR{get;set;}
[Required]
public Boolean Estado{get;set;}

public virtual Casa casa{get;set;}
public virtual Visitante visitante {get;set;}
}