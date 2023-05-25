using Zadanie1;

class Zadanide1
{
    static void Main(string[] args)
    {
        Cat murzik = new Cat("Мурзик");
        Cat batkis = new Cat("Барсик");
        Console.WriteLine("================");
        murzik.Name = "Мурзик"; //правильное имя
        murzik.Meow();
        murzik.Name = "1234";  // неправильное имя
        Console.WriteLine("================");
        murzik.Name = "Мурзикa";
        murzik.AddWeight(-2); //неправильный вес
        murzik.Weights();
        Console.WriteLine("================");
        murzik.AddWeight(5); //правильный вес
        murzik.Weights();
        Console.WriteLine("================");
        batkis.Name = "Барсик"; //правильное имя
        batkis.Meow();
        batkis.Name = "1234";  // неправильное имя
        Console.WriteLine("================");
        batkis.Name = "Барсика";
        batkis.AddWeight(-2); //неправильный вес
        batkis.Weights();
        Console.WriteLine("================");
        Console.WriteLine("================");
        batkis.AddWeight(5); //правильный вес
        batkis.Weights();
        Console.WriteLine("================");
    }
}
