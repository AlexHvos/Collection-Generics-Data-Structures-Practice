public class Node<T> {
    public Node<T> Previous;
    public Node<T> Next;
    public T Value;
    public Node(T value) {
        Value = value;
    }
    public override string ToString()
    {
        return Value.ToString();
    }
}