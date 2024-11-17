using System;

public class NodeL
{
	public NodeL(int num)
	{
		this.data = num;
	}

	public NodeL next;
	public NodeL previous;
	public int data;
}