class Program
{
    static void Main(string[] args)
    {
        user.InUsers();
    }
}
class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}
{
    public void InUsers()
    {
        Ads ads = new Ads();
        Console.WriteLine("Логин");
        Login = Console.ReadLine();
        Console.WriteLine("Имя");
        Name = Console.ReadLine();
        Console.WriteLine(" Здравствуйте, {0}!" + "\n У вас есть подписка?", Name);
        IsPremium = Convert.ToBoolean(Console.ReadLine());
        if (IsPremium == false)
        {
            ads.ShowAds();
        }
        else
        {
            Console.WriteLine("Отлично, спасибо вам что пользуетесь нашей подпиской!");
        }
    }
}
class Ads
{
    public void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }
}