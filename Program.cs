class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Score : ");
        int score = Console.ReadLIne();
        Console.WriteLine("Name = {0}", name);
        Console.WriteLine("Score = {0}", score);
        if (score <= 49)
            Console.WriteLine("grade = 0");
        if (score <= 54)
            Console.WriteLine("grade = 1");
        if (score <= 59)
            Console.WriteLine("grade = 1.5");
        if (score <= 64)
            Console.WriteLine("grade = 2");
        if (score <= 69)
            Console.WriteLine("grade = 2.5");
        if (score <= 74)
            Console.WriteLine("grade = 3");
        if (score <= 79)
            Console.WriteLine("grade = 3.5");
        if (score >= 80)
            Console.WriteLine("grade = 4");



    }
}