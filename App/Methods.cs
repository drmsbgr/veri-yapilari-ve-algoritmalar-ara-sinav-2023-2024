using App.LinkedList.Singly;

namespace App;

public static class Methods
{
    public static bool ContainsDuplicate<T>(T[] nums)
    {
        List<T> copy = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (copy.Contains(nums[i]))
                return true;
            else
                copy.Add(nums[i]);
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