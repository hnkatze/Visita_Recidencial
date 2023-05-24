public class HabitantesCService: IHabitantesCService{
//Inyeccion de dependencias.
Context context;
public HabitantesCService(Context DbContext) => context = DbContext;

//CRUD
//create
public async Task Create( HabitantesC newHabitantesC ){
    await context.AddAsync(newHabitantesC);
    await context.SaveChangesAsync();
}
//Read
public IEnumerable<HabitantesC> Read() => context.HabitantesCs;
//update
public async Task Update(Guid id, HabitantesC UpHabitantesC){
    var upge = context.HabitantesCs.Find(id);
    if(upge != null){
       upge.Parentesco = UpHabitantesC.Parentesco;


    await context.SaveChangesAsync();
}}

//Delelte

public async Task Delete(Guid id)
{
    var gener = context.HabitantesCs.Find(id);
    if(gener!= null)
    {
        context.Remove(gener);
        await context.SaveChangesAsync();}}
    
}

public interface IHabitantesCService
{
    Task Create(HabitantesC newHabitantesC);
    IEnumerable<HabitantesC> Read();
    Task Update(Guid id, HabitantesC upHabitantesC);
    Task Delete(Guid id);

}