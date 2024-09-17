namespace Real_Topic_4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, firstName, lastName, login, name2, item1, item2;
            int age, grade, studentID, age2;
            double salary, average, calc1, calc2, calc3, price1, price2, totalPrice, tax, discount, priceOwed;



            Console.WriteLine("Hello, what is your name?");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Why hello, " + name + "!");
            Console.WriteLine("How old are you, " + name + "?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine(age + " is an awesome age! May I ask your salary, " + name + "?");
            Double.TryParse(Console.ReadLine(), out salary);
            Console.WriteLine("Sweet! " + salary.ToString("C") + " is not to shabby at all, " + name + "!");
            Console.WriteLine(" ");

            Console.WriteLine("Please enter all your personal data so I can steal your identity.");
            Console.WriteLine("First name: ");
            firstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Last name:");
            lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Grade:");
            Int32.TryParse(Console.ReadLine(), out grade);
            Console.WriteLine("Student ID:");
            Int32.TryParse(Console.ReadLine(), out studentID);
            Console.WriteLine("Login:");
            login = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Average:");
            Double.TryParse(Console.ReadLine(), out average);
            Console.WriteLine("Thanks for giving me all your personal info, time to scam!");
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Student ID: " + studentID);
            Console.WriteLine("Login: " + login);
            Console.WriteLine("Average: " + average);
            Console.WriteLine(" ");

            Console.WriteLine("Whats your name?");
            name2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hello, " + name2 + ". What is your age?");
            Int32.TryParse(Console.ReadLine(), out age2);
            Console.WriteLine("In 5 years, you will be " + (age2 + 5) + " years old.");
            Console.WriteLine(" ");

            Console.WriteLine("Hi, I am a calculator, give me three numbers and I will average them.");
            Console.WriteLine("Number 1: ");
            Double.TryParse(Console.ReadLine(), out calc1);
            Console.WriteLine("Number 2: ");
            Double.TryParse(Console.ReadLine(), out calc2);
            Console.WriteLine("Number 3: ");
            Double.TryParse(Console.ReadLine(), out calc3);
            Console.WriteLine("The average of your numbers is " + ((calc1 + calc2 + calc3) / 3) + ".");
            Console.WriteLine(" ");

            Console.WriteLine("Welcome customer! What item will be your first to checkout?");
            item1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("And it's price?");
            Double.TryParse(Console.ReadLine(), out price1);
            Console.WriteLine("Next item?");
            item2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("And it's price?");
            Double.TryParse(Console.ReadLine(), out price2);
            Console.WriteLine(" ");
            totalPrice = price1 + price2;
            discount = totalPrice * 0.20;
            tax = (totalPrice + discount) * 0.13;
            Console.WriteLine("Item 1: " + item1);
            Console.WriteLine("Price: " + price1.ToString("C"));
            Console.WriteLine("Item 2: " + item2);
            Console.WriteLine("Price: " + price2.ToString("C"));
            Console.WriteLine("==================");
            Console.WriteLine("Total: " + totalPrice.ToString("C"));
            Console.WriteLine("Discount:" + discount.ToString("C"));
            Console.WriteLine("Subtotal: " + (totalPrice - discount).ToString("C"));
            Console.WriteLine("Tax: " + tax.ToString("C"));
            Console.WriteLine("==================");
            Console.WriteLine("Total Owed: " + (totalPrice - discount + tax).ToString("C"));
        }
    }
}
