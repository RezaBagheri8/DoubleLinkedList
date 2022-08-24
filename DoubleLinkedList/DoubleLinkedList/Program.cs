using DoubleLinkedList;

var linkedList = new LinkedList();

linkedList.InsertFirst(2);
linkedList.InsertFirst(546);
linkedList.InsertFirst(76);

linkedList.InsertAfter(20, 2);
linkedList.InsertAfter(333, 20);

linkedList.Delete(333);

linkedList.DeleteLast();
linkedList.DeleteLast();
linkedList.DeleteLast();
linkedList.DeleteLast();
linkedList.DeleteLast();
linkedList.DeleteLast();
linkedList.DeleteLast();



linkedList.Print();