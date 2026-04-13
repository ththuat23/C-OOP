using System;

public class Stack
{
    private int[] data;
    private int top;
    private int max;

    // Property để lớp con dùng
    protected int[] Data
    {
        get { return data; }
    }

    protected int Top
    {
        get { return top; }
        set { top = value; }
    }

    protected int Max
    {
        get { return max; }
    }

    public Stack(int max)
    {
        this.max = max;
        data = new int[max];
        top = -1;
    }

    public void Push(int x)
    {
        if (top == max - 1)
        {
            Console.WriteLine("Stack day");
            return;
        }
        data[++top] = x;
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack rong");
            return -1;
        }
        return data[top--];
    }

    // virtual
    public virtual void Print()
    {
        for (int i = 0; i <= top; i++)
            Console.Write(data[i] + " ");
        Console.WriteLine();
    }
}