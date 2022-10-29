// See https://aka.ms/new-console-template for more information

// stack, pointer, bubble sort
using FirstLab;

class Program
{
    static void Main(string[] args)
    {
        Stack values = new Stack();

        values.Push(7);
        values.Push(3);
        values.Push(10);
        values.Push(-7);
        values.Push(1);

        values.Print();

        for (int i = 0; i < values.size; i++)
        {
            for (int j = 0; j < values.size - i - 1; j++)
            {
                if (values.Get(j) > values.Get(j + 1))
                {
                    int buf = values.Get(j + 1);
                    values.Set(j + 1, values.Get(j));
                    values.Set(j, buf);
                }
            }
        }
        
        values.Print();
    }
}

