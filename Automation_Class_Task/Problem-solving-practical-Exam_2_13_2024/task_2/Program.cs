// 2.	В порядке возрастания выведите числа, которые входят в десятичную запись n натуральных.
int n = 428;

//int first_digit = n / 100;
//int mid_digit = (n / 10) % 10;
//int last_digit = n % 10;

//Console.WriteLine(first_digit);
//Console.WriteLine(mid_digit);
//Console.WriteLine(last_digit);


List<int> digits = new List<int>();

// Retrieve digit in n
while (n > 0)
{
    int digit = n % 10;
    digits.Add(digit);
    n = n / 10;
}

// Sort retrieved digit that saved in list
digits.Sort();


int result = 0;

foreach (int digit in digits)
{
    // save digin in digits to one int variable
    result = result * 10 + digit;
    // print digit result
    Console.Write(digit);
}

// print result variable
Console.WriteLine();
Console.WriteLine(result);
