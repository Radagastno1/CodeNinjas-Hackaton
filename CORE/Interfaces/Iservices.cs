namespace CORE.interfaces;

public interface Iservice<T>
{
    public T add(T obj);
    public List<T> Get();
    public T GetById(int id);
    public T Put(T obj);
    public T Delete(T obj);
}