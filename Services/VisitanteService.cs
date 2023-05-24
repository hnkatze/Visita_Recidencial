public class VisitanteService: IVisitanteService{
//Inyeccion de dependencias.
Context context;
public VisitanteService(Context DbContext) => context = DbContext;

//CRUD
//create
public async Task Create( Visitante newVisitante ){
    await context.AddAsync(newVisitante);
    await context.SaveChangesAsync();
}
//Read
public IEnumerable<Visitante> Read() => context.Visitantes;
//update
public async Task Update(Guid id, Visitante UpVisitante){
    var upge = context.Visitantes.Find(id);
    if(upge != null){
       upge.Identificador = UpVisitante.Identificador;
       upge.Nombre = UpVisitante.Nombre;
       upge.Edad = UpVisitante.Edad;
       upge.Sexo = UpVisitante.Sexo;

    await context.SaveChangesAsync();
}}

//Delelte

public async Task Delete(Guid id)
{
    var gener = context.Visitantes.Find(id);
    if(gener!= null)
    {
        context.Remove(gener);
        await context.SaveChangesAsync();}}
    
}

public interface IVisitanteService
{
    Task Create(Visitante newVisitante);
    IEnumerable<Visitante> Read();
    Task Update(Guid id, Visitante upVisitante);
    Task Delete(Guid id);

}