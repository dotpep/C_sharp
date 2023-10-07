using System;

namespace HomeWork1
{
    static class Spam
    {
        static public string email;
        static public string name;
        static public string link;


        public static void Message(string email, string name, string link)
        {
            Console.WriteLine($"Кому: {email}");
            Console.WriteLine($"Добрый вечер {name} у нас есть для вас очень интересная статья по ссылке: {link}");
        }

    }
}
