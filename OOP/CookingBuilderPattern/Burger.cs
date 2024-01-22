using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingBuilderPattern
{
    public class Burger
    {
        // Булочка
        public string Bun { get; set; }
        // Пирожок
        public string Patty { get; set; }
        // Сыр
        public string Cheese { get; set; }
        // Салат
        public string Lettuce { get; set; }
        // Помдор
        public string Tomato { get; set; }
        // переопределение метода tostring c#
        public override string ToString()
        {
            return $"Bun: {Bun}, Patty: {Patty}, Cheese: {Cheese}, Lettuce: {Lettuce}, Tomato: {Tomato}";
        }

    }

    public interface IBurgerBuilder
    {
        //Булочка
        void AddBun();
        //Пирожок
        void AddPatty();
        //Сыр
        void AddCheese();
        //Салат
        void AddLettuce();
        //Помидор
        void AddTomato();
        //метод интерфейса который возвращает готовый бургер
        Burger GetBurger();
    }

    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger = new Burger();

        public void AddBun()
        {
            _burger.Bun = "Булочка";
        }
        public void AddPatty()
        {
            _burger.Patty = "Пирожок";
        }

        public void AddCheese()
        {
            _burger.Cheese = "Сыр";
        }

        public void AddLettuce()
        {
            _burger.Lettuce = "Салат";
        }

        public void AddTomato()
        {
            _burger.Tomato = "Помидор";
        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }


    public class BurgerDirector
    {
        private IBurgerBuilder _builder;

        public BurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }

        // создание стандартного бургера
        public void MakeStandardBurger()
        {
            _builder.AddBun();
            _builder.AddPatty();
            _builder.AddCheese();
            _builder.AddLettuce();
            _builder.AddTomato();
        }

        // создание вегетарианского бургера
        public void MakeVeggieBurger()
        {
            _builder.AddBun();
            _builder.AddLettuce();
            _builder.AddTomato();
        }

        // создание двойного бургера с двойным сыром
        public void MakeDoubleCheeseBurger()
        {
            _builder.AddBun();
            _builder.AddPatty();
            _builder.AddCheese();
            _builder.AddPatty();
            _builder.AddCheese();
            _builder.AddLettuce();
            _builder.AddTomato();
        }
    }
}
