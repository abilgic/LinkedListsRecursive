
var linkedlist = new LinkedListsRecursive.LinkedList();
var head = linkedlist.root;

head = linkedlist.Insert(head, 1);
head = linkedlist.Insert(head, 2);
head = linkedlist.Insert(head, 3);
head = linkedlist.Insert(head, 4);
head = linkedlist.Insert(head, 5);

Console.WriteLine("After adding elements to the Linked List");
linkedlist.Print(head);
Console.WriteLine();