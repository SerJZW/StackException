namespace Stack;
internal class Programm
{
    public static void Main()
    {
        try
        {
            MainStack myStack = new MainStack(3);
            MainList myList = new MainList();
            //myList.Add(1);
            //myList[2]++;

            //myList.RemoveLast();
            //myList.RemoveLast();
            //myStack.Pop();
           
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            Console.WriteLine("Found " + myStack.Find(3)); 
            myStack.Push(6);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }






    }
}
