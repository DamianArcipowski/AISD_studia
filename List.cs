using System;

public class List
{
	public NodeL head;
	public NodeL tail;
	public int count = 0;
	public NodeL tmp = new NodeL(7);

	public void AddFirst(int num) {

    if (head == null)
    {
        this.head = tmp;
        this.tail = tmp;
    }
    else
    {
        tmp.next = head;
        this.head.previous = tmp;
        this.head = tmp;
    }

    count++;
    }

	public void AddLast(int num) 
	{
		tmp.p = this.tail;
		this.tail.n = tmp;
		this.tail = tmp;
	}

	NodeL RemoveFirst() 
    {

        if (head == null)
            return null;

        NodeL removedNode = head;

        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            head = head.next;
            head.previous = null;
        }

        count--;


        return removedNode;
    }
	NodeL RemoveLast()
    {

        if (tail == null)
            return null;

        NodeL removedNode = tail;

        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            tail = tail.previous;
            tail.next = null;
        }

        count--;

        return removedNode;
    }
	string ToString()
    {

        if (head == null)
            return "Lista jest pusta";

        System.Text.StringBuilder result = new System.Text.StringBuilder();

        NodeL current = head;
        while (current != null)
        {
            result.Append(current.data);

            if (current.next != null)
                result.Append(", ");

            current = current.next;
        }

        return result.ToString();
    }
}
