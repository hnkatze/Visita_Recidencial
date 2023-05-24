using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class HabitantesC{
[Key]
public Guid HabiId{get;set;}

[Required]
public String Parentesco{get;set;}
[ForeignKey("CasaId")]
public Guid CasaId{get;set;}

[ForeignKey("ResidenteId")]
public Guid ResidenteId{get;set;}

public virtual Residente residente{get;set;}
public virtual Casa casa{get;set;}
}