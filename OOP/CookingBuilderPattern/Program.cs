using CookingBuilderPattern;

class Program
{
    static void Main(string[] args)
    {
        BurgerBuilder builder = new BurgerBuilder();
        BurgerDirector director = new BurgerDirector(builder);

        // создание стандартного бургера
        Console.WriteLine("Cooking Standard Burger...");
        director.MakeStandardBurger();
        Burger burger1 = builder.GetBurger();
        Console.WriteLine(burger1);

        //// создание вегетарианского бургера
        //Console.WriteLine("Cooking Veggie Burger...");

    }
}