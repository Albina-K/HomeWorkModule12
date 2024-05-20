namespace HomeWorkModule12
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<User> list = new List<User>()
            {
                new User ("AAA", "aaa", false),
                new User ("BBB", "bbb", true),
                new User ("CCC", "ccc", false)
            };

            foreach (var item in list)
            {
                Console.WriteLine("Hello," + item.Name);
                if (item.IsPremium != true)
                {
                    ShowAds();
                }
            }

            static void ShowAds()
            {
                Console.WriteLine("Посетите наш сайт с бесплатными играми ...");
                // Остановка на 1 с
                Thread.Sleep(1000);

                Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
                // Остановка на 2 с
                Thread.Sleep(2000);

                Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
                // Остановка на 2 с
                Thread.Sleep(3000);
            }
        }
    }
}
