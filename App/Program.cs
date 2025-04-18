using App;
using App.LinkedList.Doubly;

int[] nums = [1, 2, 3, 4, 5];

Console.WriteLine(Methods.ContainsDuplicate(nums));

var linkedList = Methods.ToSinglyLinkedList(nums);
var reversed = Methods.ReverseList(linkedList.Head);

var db = new DoublyLinkedList<int>([3, 4, 5, 6, 7, 8]);

foreach (var item in db)
    Console.WriteLine(item);

reversed.RemoveLast();

foreach (var item in reversed)
    Console.WriteLine(item);

Console.ReadKey();



