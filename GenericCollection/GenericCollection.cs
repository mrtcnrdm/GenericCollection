using System.Collections;

public class GenericCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>
{
    private List<T> items = new List<T>();

    // IList<T> members
    public T this[int index]
    {
        get => items[index];
        set => items[index] = value;
    }

    public int Count => items.Count;

    public bool IsReadOnly => false;

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Clear()
    {
        items.Clear();
    }

    public bool Contains(T item)
    {
        return items.Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        items.CopyTo(array, arrayIndex);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    public int IndexOf(T item)
    {
        return items.IndexOf(item);
    }

    public void Insert(int index, T item)
    {
        items.Insert(index, item);
    }

    public bool Remove(T item)
    {
        return items.Remove(item);
    }

    public void RemoveAt(int index)
    {
        items.RemoveAt(index);
    }

    // ICollection<T> member
    void ICollection<T>.Add(T item)
    {
        Add(item);
    }

    // IEnumerable<T> member
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
