namespace SuwarSuwirApp.Controllers
{
    // Interface sederhana CRUD
    public interface C_ICrudController<T>
    {
        OperationResult<T> Create(T entity);
        OperationResult<T> Read(int id);
        OperationResult<T> Update(T entity);
        OperationResult<bool> Delete(int id);
    }
}
