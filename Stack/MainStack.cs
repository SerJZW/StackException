using Stack;
using Stack.Exceptions;

internal class MainStack
{
    private int size;
    private MainList list;

    public MainStack(int size)
    {
        if (size <= 0)
        {
            throw new CapacityException("Размер стека должен быть больше 0");
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
            throw new IndexValueException("Некорректный индекс для доступа к элементу в стеке");
        }
        var data = list.RemoveLast();
        list.Add(data);
        return data;
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
