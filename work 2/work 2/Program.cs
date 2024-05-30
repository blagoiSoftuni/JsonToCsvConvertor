// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace Methods_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwordToCheck = Console.ReadLine();
            PasswordValidator(passwordToCheck);
        }

        static void PasswordValidator(string pass)
        {
            int counter = 3; // bool result = true;
            if (!IsCorrectLength(pass))
            {
                counter--; // result = false;
                Console.WriteLine("Password must be between 6 and 10 characters.");
            }

            if (!IsLetterOrDigits(pass))
            {
                counter--; // result = false;
                Console.WriteLine("Password must consist only of letters and digits.");
            }

            if (!IsConsistsTwoDigits(pass))
            {
                counter--; // result = false;
                Console.WriteLine("Password must have at least 2 digits.");
            }

            if (counter == 3) // result == true;
            {
                Console.WriteLine("Password is valid.");
            }
        }

        static bool IsConsistsTwoDigits(string password)
        {
            bool result = false;
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    counter++;

                    if (counter == 2)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        static bool IsLetterOrDigits(string password)
        {
            bool result = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (!Char.IsLetterOrDigit(password[i]))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        static bool IsCorrectLength(string password)
        {
            bool result = false;
            if (password.Length >= 6 && password.Length <= 10)
            {
                result = true;
            }

            return result;
        }

        static int ReturnAValue(int x)
        {
            // We return the result of computing x * 10 back to the caller.
            // Notice how we are returning an int, which matches the method's return type.
            return x * 10;
        }

        static void Main()
        {
            // We can use the returned value any way we want, such as storing it in a variable.
            int num = ReturnAValue(5);
            // Prints 50 to the console.
            Console.WriteLine(num);
        }
    }
    int[] numbers = { 3, 10, 4, 6, 8 };
    static bool isTen(int n)
    {
        return n == 10;
    }

    // `Array.Exists` calls the method passed in for every value in `numbers` and returns true if any call returns true.
    Array.Exists(numbers, isTen);

Array.Exists(numbers, (int n) => {
  return n == 10;
});

// Typical syntax
// (input-parameters) => { <statements> }
}