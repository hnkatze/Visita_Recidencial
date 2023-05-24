public class VisitaService: IVisitaService{
//Inyeccion de dependencias.
Context context;
public VisitaService(Context DbContext) => context = DbContext;

//CRUD
//create
public async Task Create( Visita newVisita ){
    await context.AddAsync(newVisita);
    await context.SaveChangesAsync();
}
//Read
public IEnumerable<Visita> Read() => context.Visitas;
//update
public async Task Update(Guid id, Visita UpVisita){
    var upge = context.Visitas.Find(id);
    if(upge != null){
       upge.FechaE = UpVisita.FechaE;
       upge.FechaS = UpVisita.FechaS;
       upge.QR = UpVisita.QR;
       upge.Estado = UpVisita.Estado;

    await context.SaveChangesAsync();
}}

//Delelte

public async Task Delete(Guid id)
{
    var gener = context.Visitas.Find(id);
    if(gener!= null)
    {
        context.Remove(gener);
        await context.SaveChangesAsync();}}
    
}

public interface IVisitaService
{
    Task Create(Visita newVisita);
    IEnumerable<Visita> Read();
    Task Update(Guid id, Visita upVisita);
    Task Delete(Guid id);

}