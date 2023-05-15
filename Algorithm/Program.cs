class Program
{
    static void Main(string[] args)
    {
    Algoritm algoritm = new Algoritm();
        algoritm.Lines();
        algoritm.Sicl();
        algoritm.Razv();

        Console.ReadKey();
    }
}

class Algoritm
{
    public void Lines()
    {
        Console.WriteLine("Как вас зовут?");
        string name = Console.ReadLine();
        string greetings = ("Привет, " + name);
        Console.WriteLine(greetings);
    }
    public void Sicl()
    {
        Console.WriteLine("Сколько элементов будет в массиве?");
        var count = Convert.ToInt32(Console.ReadLine());
        var array = new string[count];
        for (int i = 0; i < count; i++)
        {
            array[i] = Console.ReadLine();
        }
        Console.WriteLine("Все эллементы записаны:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
    public void Razv()
    {
        Console.WriteLine("Введите свой возраст");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age > 13) 
        {
            Console.WriteLine("Вы усспешно зарегестрированы!");
        }
        else
        {
            Console.WriteLine("Пользователи младше 14 лет не могут быть зарегестрированы");
        }
    }
}
