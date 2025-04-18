using App.LinkedList.Doubly;

namespace App.LinkedList.Contracts;

public interface IDoublyLinkedList<T> : IEnumerable<T>
{
    DbNode<T>? Head { get; }
    DbNode<T>? Tail { get; }

    void AddFirst(T item);
    void AddLast(T item);
    T RemoveFirst();
    T RemoveLast();
}