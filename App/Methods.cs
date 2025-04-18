using App.LinkedList.Singly;

namespace App;

public static class Methods
{
    public static bool ContainsDuplicate<T>(T[] nums)
    {
        //nums = [1,2,2,3,4,5,6]
        var copy = new List<T>();

        //copy = []

        foreach (T item in nums)
        {
            if (copy.Contains(item))
                return true;
            else
                copy.Add(item);
        }

        return false;
    }

    public static SinglyLinkedList<T> ReverseList<T>(SinglyLinkedListNode<T>? head)
    {
        ArgumentNullException.ThrowIfNull(head);

        var reversed = new SinglyLinkedList<T>();

        var current = head;

        while (current != null)
        {
            reversed.AddFirst(current.Value);
            current = current.Next;
        }

        return reversed;
    }

    public static SinglyLinkedList<T> ToSinglyLinkedList<T>(T[] array)
    {
        var linkedList = new SinglyLinkedList<T>();

        foreach (var item in array)
            linkedList.AddLast(item);

        return linkedList;
    }
}