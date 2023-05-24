public class ResidenteService: IResidenteService{
//Inyeccion de dependencias.
Context context;
public ResidenteService(Context DbContext) => context = DbContext;

//CRUD
//create
public async Task Create( Residente newResidente ){
    await context.AddAsync(newResidente);
    await context.SaveChangesAsync();
}
//Read
public IEnumerable<Residente> Read() => context.Residentes;
//update
public async Task Update(Guid id, Residente UpResidente){
    var upge = context.Residentes.Find(id);
    if(upge != null){
       upge.Identificador = UpResidente.Identificador;
       upge.Nombre = UpResidente.Nombre;
       upge.Telefono = UpResidente.Telefono;
      

    await context.SaveChangesAsync();
}}

//Delelte

public async Task Delete(Guid id)
{
    var gener = context.Residentes.Find(id);
    if(gener!= null)
    {
        context.Remove(gener);
        await context.SaveChangesAsync();}}
    
}

public interface IResidenteService
{
    Task Create(Residente newResidente);
    IEnumerable<Residente> Read();
    Task Update(Guid id, Residente upResidente);
    Task Delete(Guid id);

}