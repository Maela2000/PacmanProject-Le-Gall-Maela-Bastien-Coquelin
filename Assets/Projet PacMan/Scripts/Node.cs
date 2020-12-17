using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
	public int X;
	public int Y;
	public int depth;
	public List<Node> children;
	public Node parent;
    private int v;

    public Node(int v)
    {
        this.v = v;
    }

    public Node(int X, int Y)
	{
		this.X = X;
		this.Y = Y;
		this.depth = -1;
		children = new List<Node>();

	}
}
