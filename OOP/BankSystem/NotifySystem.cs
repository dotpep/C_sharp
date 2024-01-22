using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class MainNotifySystem
    {
        static public void TestNotifySystem()
        {
            NotifySystem notifySystem = new NotifySystem();

            Student student1 = new Student("William");
            Student student2 = new Student("Ashley");

            notifySystem.RegisterObserver(student1);
            notifySystem.RegisterObserver(student2);

            notifySystem.NotifyObserver("You're in OOP class and you must prove basic knowledges that you gain");

            notifySystem.RemoveObserver(student2);
            notifySystem.NotifyObserver("Welcome to Computer Science class");
        }
    }

    public interface IObserver
    {
        void Update(string message);
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver(string message);
    }

    public class NotifySystem : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void NotifyObserver(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

    }

    public class Student : IObserver
    {
        public string name;

        public Student(string name)
        {
            this.name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{name} -- {message}");
        }
    }
}
