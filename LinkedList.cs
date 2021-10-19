using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Add first : \n");
		LinkedList myList1 = new LinkedList();
		myList1.addFirst(10);
		myList1.addFirst(20);
		myList1.addFirst(30);
		myList1.addFirst(40);
		myList1.addFirst(50);
		myList1.addFirst(60);
		myList1.printAllNodes();

	}
}
public class Node
{
	public Node next;
	public int data;
}
public class LinkedList{

	//head to store the address of first node 
    private Node head;
	
	public void printAllNodes()
	{
		Node current=head;
		while(current!=null)
		{
			Console.WriteLine(current.data);
			current=current.next;
		}
	}
	
	public void addFirst(int data)
	{
		Node toAdd=new Node();
		toAdd.data=data;
		toAdd.next=head;
		head=toAdd;
	}

}


