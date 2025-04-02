using App;

int[] nums = [1, 2, 3, 4, 5];

Console.WriteLine(Methods.ContainsDuplicate(nums));

var linkedList = Methods.ToSinglyLinkedList(nums);
var reversed = Methods.ReverseList(linkedList.Head);

reversed.RemoveLast();

foreach (var item in reversed)
    Console.WriteLine(item);



