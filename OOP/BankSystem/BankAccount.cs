namespace BankSystem
{
    static public class MainBankAccount
    {
        static public void TestBankAccount()
        {
            // BankAccount is reference data type that we created using another class reference data type

            BankAccount account1 = new BankAccount(3, "jason", "watson");
            //account.balance = 2500.0;
            //Console.WriteLine(account.id + " " + account.name + " " + account.balance);

            account1.setBalance(653.336);

            Console.WriteLine(account1.getId() + " " + account1.getName() + " " + account1.getBalance());


            BankAccount account2 = new BankAccount(5, "john", "doe");

            Console.WriteLine(account2.getId() + " " + account2.getName() + " " + account2.getBalance());

            // Primitive data type: int, double, bool, long, short
            // Reference is String, Array, List, class and etc
        }
    }


    internal class BankAccount
    {
        private int _id;
        public string first_name;
        public string last_name;
        private double _balance;

        //string? username;
        //readonly string rules;

        public BankAccount(int id, string first_name, string last_name)
        {
            //this.id = id;
            //this.name = name;
            //this.balance = balance;
            setId(id);
            setName(first_name, last_name);
            //setBalance(balance);
        }

        public int getId()
        {
            return _id;
        }

        public void setId(int id)
        {
            if (id >= 0)  // By default int primitive data type values is 0
            {
                this._id = id;
            }
        }

        public string getName()
        {
            return first_name + " " + last_name;
        }

        public void setName(string first_name, string last_name)
        {
            if (
                first_name.Length > 2 &&
                first_name is not null &&
                last_name.Length > 2 &&
                last_name is not null
                )
            {
                this.first_name = first_name;
                this.last_name = last_name;
            }
        }

        public double getBalance()
        {
            return _balance;
        }

        public void setBalance(double balance)
        {
            if (balance >= 0)  // By default double primitive data type values is 0.0
            {
                this._balance = balance;
            }
        }

        //public string Name { get => name; set => name = value; }
        //public double Balance { get => balance; set => balance = value; }
    }
}
