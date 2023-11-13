using Stack;
using Stack.Exceptions;

internal class MainStack
{
    private int size;
    private MainList list;

    public MainStack(int size)
    {
        try
        {
            if (size <= 0)
            {
                throw new CapacityException("Размер стека должен быть больше 0");
            }
        }
        catch (CapacityException e)
        {
            Console.WriteLine($"{e.Message}");
        }

        this.size = size;
        list = new MainList();
    }


    public MainStack(MainStack current)
    {
        list = current.list;
    }

    public void Push(int item)
    {
        if (list.Count == size)
        {
            throw new StackOverFlowException("Стек переполнен");
        }
        if (item < 0)
        {
            throw new ItemValueException("Нельзя добавить отрицательное значение в стек");
        }

        list.Add(item);
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            throw new StackUnderflowException("Стек пуст, нельзя выполнить извлечение.");
        }
        return list.RemoveLast();
    }

    public int? Peek()
    {
        if (IsEmpty())
        {
            throw new NullException("Top was Null");
        }
        var data = list.RemoveLast();
        list.Add(data);
        return data;
    }

    public int Find(int item)
    {
        Node current = list.Head;
        int index = 0;

        while (current != null)
        {
            if (current.Data == item)
            {
                return index; 
            }

            current = current.Next;
            index++;
        }

        throw new IndexValueException($"Элемент {item} не найден в стеке");
    }

    public override string ToString()
    {
        string output = " ";
        Node current = list.Head;
        for (int i = 0; i < size; i++)
        {
            output += current.Data + " ";
            current = current.Next;
        }
        return output;
    }

    public bool IsEmpty()
    {
        return list.Count == 0;
    }

}
