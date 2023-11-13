namespace Stack;
internal class Programm
{
    public static void Main()
    {
        try
        {
            MainStack myStack = new MainStack(4);
            MainList myList = new MainList();
            //myList.Add(1);
            //myList[2]++;

            //myList.RemoveLast();
            //myList.RemoveLast();
            //myStack.Pop();
           
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(5);
            Console.WriteLine("Found " + myStack.Find(4));
           
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }






    }
}
