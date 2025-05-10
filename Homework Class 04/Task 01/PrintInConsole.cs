

namespace Task_01
{
    public class PrintInConsole<T>
    {
        public void Print(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
        public void PrintCollection(List <T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
