using System.ComponentModel;

namespace BankSystem
{
    public enum CurrenciesTest // By USD
    {
        [Description("Kazakh tenge")] KZT = 447,
        [Description("Russian ruble")] RUB = 90,
        [Description("Europe euro")] EUR = 1,
        [Description("United States dollar")] USD = 1
    }

    static public class MainBankAccount
    {
        static private void TestCase1()
        {
            // BankAccount is reference data type that we created using another class reference data type

            //BankAccount account1 = new BankAccount(3, "jason", "watson");
            ////account.balance = 2500.0;
            ////Console.WriteLine(account.id + " " + account.name + " " + account.balance);

            //account1.setBalance(653.336);

            //Console.WriteLine(account1.getId() + " " + account1.getName() + " " + account1.getBalance());


            //BankAccount account2 = new BankAccount(5, "john", "doe");

            //Console.WriteLine(account2.getId() + " " + account2.getName() + " " + account2.getBalance());

            // Primitive data type: int, double, bool, long, short
            // Reference is String, Array, List, class and etc
        }

        static private void TestCase2()
        {
            //BankAccount account1 = new BankAccount(first_name: "alex", last_name: "kohei");
            //BankAccount account2 = new BankAccount(first_name: "jason", last_name: "watson");
            //BankAccount account3 = new BankAccount(first_name: "john", last_name: "doe");

            //account1.setBalance(amount: 5500);
            //account2.setBalance(amount: 7500);
            //account3.setBalance(amount: 15500);

            //Console.WriteLine(account1);
            //Console.WriteLine(account2);
            //Console.WriteLine(account3);

            //account1.Transaction(bankAccount: account3, amount: 6000);
            //Console.WriteLine(account1);
            //Console.WriteLine(account3);

            //account1.setBalance(currency: "KZT", amount: 80000);
            //Console.WriteLine(account1);

            //account3.Transaction(bankAccount: account1, amount: 10500);
            //Console.WriteLine(account3);
            //Console.WriteLine(account1);


            //string name = CurrenciesTest.KZT.ToString();
            //double value = (double)CurrenciesTest.KZT;
            //Console.WriteLine(name);
            //Console.WriteLine(value);
        }

        static public void TestBankAccount()
        {
            BankAccount account1 = new BankAccount(first_name: "alex", last_name: "kohei");
            BankAccount account2 = new BankAccount(first_name: "jason", last_name: "watson");
            BankAccount account3 = new BankAccount(first_name: "john", last_name: "doe");

            int id = account1.Id;
            string username = account1.FirsName;
            string surname = account1.LastName;
            username = "Jimmy";

            double balance = account1.Balance;

            Console.WriteLine(id);
            Console.WriteLine(username);
            Console.WriteLine(surname);
            Console.WriteLine(balance);

            Console.WriteLine("---");

            account1.FirsName = "matthew";

            account1.Balance = 500;
            account2.Balance = 700;
            account3.Balance = 375;

            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);

            Console.WriteLine("---");

            account2.Balance = 2000;

            account1.TransferToBalance(currency: "RUB", amount: 89000);
            account2.TransferToAccount(otherAccount: account3, amount: 1260);
            account3.TransferWithCurrency(otherAccount: account1, currency: "KZT", amount: 180000);

            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);

        }
    }


    public class BankAccount
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private double _balance;

        private int _generateUniqueId = 1;

        //string? username;
        //readonly string rules;

        public BankAccount(string first_name, string last_name)
        {
            _id = _generateUniqueId++;
            SetFullName(first_name, last_name);
        }

        public int Id
        {
            get { return _id; }
        }

        public string FirsName
        {
            get { return _firstName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 2)
                {
                    _firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 3)
                {
                    _lastName = value;
                }
            }
        }

        public void SetFullName(string firstName, string lastName)
        {
            FirsName = firstName;
            LastName = lastName;
        }

        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)  // By default double primitive data type values is 0.0
                {
                    _balance = Math.Round(value, 2, MidpointRounding.AwayFromZero);
                }
            }
        }


        /// <summary>
        /// Transfers a specific amount of money from one account to another.
        /// </summary>
        public void TransferToAccount(BankAccount otherAccount, double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                otherAccount.Balance += amount;
            }
            else
            {
                Console.WriteLine("No needed balance in your bank!");
            }
        }


        /// <summary>
        /// Transfers a specific amount of money in a different currency from one account to another.
        /// </summary>
        public void TransferWithCurrency(BankAccount otherAccount, string currency, double amount)
        {
            if (amount >= 0)
            {
                double convertedAmount = ConvertAmount(currency: currency, amount: amount);
                TransferToAccount(otherAccount, convertedAmount);
            }
        }


        /// <summary>
        /// Transfers a specific amount of money in a different currency to the balance.
        /// </summary>
        public void TransferToBalance(string currency, double amount)
        {
            if (amount >= 0)
            {
                double convertedAmount = ConvertAmount(currency: currency, amount: amount);
                Balance += convertedAmount;
            }
        }


        /// <summary>
        /// Converts a specific amount of money in a different currency to USD.
        /// </summary>
        private double ConvertAmount(string currency, double amount)
        {
            return currency switch
            {
                // FIXME: 
                "KZT" => amount / (double)Currencies.KZT,
                "RUB" => amount / (double)Currencies.RUB,
                "EUR" => amount / (double)Currencies.EUR,
                _ => throw new ArgumentException("There is no provied Currency in our bank", nameof(currency))
            };
        }



        // Example of Method Overloading
        public void Transfer(BankAccount otherAccount, double amount)
        {
            /// <summary> make Transaction to other account </summary>

            if (Balance >= amount)
            {
                Balance -= amount;
                otherAccount.Balance += amount;
            }
            else
            {
                Console.WriteLine("No needed balance in your bank!");
            }
        }


        public void Transfer(BankAccount otherAccount, string currency, double amount)
        {

            if (amount >= 0)
            {
                double convertedAmount = 0;

                if (currency.Equals(Currencies.KZT.ToString()))
                {
                    convertedAmount = amount / (double)Currencies.KZT;
                }
                else if (currency.Equals(Currencies.RUB.ToString()))
                {
                    convertedAmount = amount / (double)Currencies.RUB;
                }
                else if (currency.Equals(Currencies.EUR.ToString()))
                {
                    convertedAmount = amount / (double)Currencies.EUR;
                }
                else
                {
                    Console.WriteLine("There is no provied Currency in our bank");
                }

                Transfer(otherAccount: otherAccount, amount: convertedAmount);
            }
        }

        public void Transfer(string currency, double amount)
        {
            if (amount >= 0)
            {
                if (currency.Equals(Currencies.KZT.ToString()))
                {
                    Balance += amount / (double)Currencies.KZT;
                }
                else if (currency.Equals(Currencies.RUB.ToString()))
                {
                    Balance += amount / (double)Currencies.RUB;
                }
                else if (currency.Equals(Currencies.EUR.ToString()))
                {
                    Balance += amount / (double)Currencies.EUR;
                }
                else
                {
                    Console.WriteLine("There is no provied Currency in our bank");
                }
            }
        }


        public enum Currencies // By USD
        {
            [Description("Kazakh tenge")] KZT = 447,
            [Description("Russian ruble")] RUB = 90,
            [Description("Europe euro")] EUR = 1,
            [Description("United States dollar")] USD = 1
        }

        public override string ToString()
        {
            return base.ToString() + ": " + _id.ToString() + " " + _firstName + " " + _lastName + " " + _balance.ToString() + "$";
        }


        //public void Transaction(BankAccount bankAccount, double amount)
        //{
        //    if (this._balance >= amount)
        //    {
        //        this._balance -= amount;
        //        bankAccount._balance += amount;
        //    }
        //    else
        //    {
        //        Console.WriteLine("No needed balance in your bank!");
        //    }
        //}

        //public void setBalance(double amount)
        //{
        //    if (amount >= 0)  // By default double primitive data type values is 0.0
        //    {
        //        this._balance = amount;
        //    }
        //}

        //public double setBalance
        //{
        //    set { _balance = Math.Round(value, 2, MidpointRounding.AwayFromZero); }
        //}

        //public void setBalance(string currency, double amount)
        //{
        //    if (amount >= 0) ;
        //    if (currency.Equals(CurrenciesTest.KZT.ToString()))
        //    {
        //        this._balance += amount / (double)Currencies.KZT;
        //    }
        //    else if (currency.Equals(CurrenciesTest.RUB.ToString()))
        //    {
        //        this._balance += amount / (double)Currencies.RUB;
        //    }
        //    else if (currency.Equals(CurrenciesTest.EUR.ToString()))
        //    {
        //        this._balance += amount / (double)Currencies.EUR;
        //    }
        //    else
        //    {
        //        Console.WriteLine("There is no provied Currency in our bank");
        //    }

        //}


        //public int getId()
        //{
        //    return _id;
        //}

        //public void setId(int id)
        //{
        //    if (id >= 0)  // By default int primitive data type values is 0
        //    {
        //        this._id = id;
        //    }
        //}

        //public string getName()
        //{
        //    return _firstName + " " + _lastName;
        //}

        //public void SetName(string first_name, string last_name)
        //{
        //    if (
        //        first_name.Length > 2 &&
        //        first_name is not null &&
        //        last_name.Length > 2 &&
        //        last_name is not null
        //        )
        //    {
        //        this._firstName = first_name;
        //        this._lastName = last_name;
        //    }
        //}

        //public double getBalance()
        //{
        //    return _balance;
        //}

        //public string Name { get => name; set => name = value; }
        //public double Balance { get => balance; set => balance = value; }
    }
}
