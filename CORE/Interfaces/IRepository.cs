namespace CORE.Interfaces;

public interface IRepository<T>
{
    public T Create(T obj);
    public T Update(T obj);
    public List<T> Get();
    public T GetById(int id);
    public void DeleteById(int id);
}