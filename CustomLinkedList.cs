public class CustomLinkedList<T> {
    public Node<T> First {get; set;}
    public Node<T> Current {get; set;}
    public Node<T> Last {get; set;}
    public void Add(T value) {
        Node<T> newNode = new Node<T>(value);
        if (Current == null) {
            First = newNode;
            Current = newNode;
        }
        else {
            Current.Next = newNode;
            newNode.Previous = Current;
            Current = newNode;
        }
        Last = newNode;
    }

    public IEnumerator<T> GetEnumerator() {
        Current = First;
        while (Current != null) {
            yield return Current.Value;
            Current = Current.Next;
        }
    }

    public IEnumerable<T> GetEnumerableDESC() {
        Current = Last;
        while (Current != null) {
            yield return Current.Value;
            Current = Current.Previous;
        }
    }
}