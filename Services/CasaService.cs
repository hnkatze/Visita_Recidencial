public class CasaService: ICasaService{
//Inyeccion de dependencias.
Context context;
public CasaService(Context DbContext) => context = DbContext;

//CRUD
//create
public async Task Create( Casa newCasa ){
    await context.AddAsync(newCasa);
    await context.SaveChangesAsync();
}
//Read
public IEnumerable<Casa> Read() => context.Casas;
//update
public async Task Update(Guid id, Casa UpCasa){
    var upge = context.Casas.Find(id);
    if(upge != null){
       upge.Numero = UpCasa.Numero;
       upge.Bloque = UpCasa.Bloque;
       upge.Calle = UpCasa.Calle;
       upge.Referencia = UpCasa.Referencia;

    await context.SaveChangesAsync();
}}

//Delelte

public async Task Delete(Guid id)
{
    var gener = context.Casas.Find(id);
    if(gener!= null)
    {
        context.Remove(gener);
        await context.SaveChangesAsync();}}
    
}

public interface ICasaService
{
    Task Create(Casa newCasa);
    IEnumerable<Casa> Read();
    Task Update(Guid id, Casa upCasa);
    Task Delete(Guid id);

}