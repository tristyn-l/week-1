using System;

namespace FizzBuzz
{
    internal class Fizzy
    {
        private string _fizz = "fizz";
        private string _buzz = "buzz";
        private string _fizzbuzz = "fizzbuzz";

        static void Main(string[] args)
        {
            // init variables
            var firstCheck = 0;
            var secondCheck = 0;
            var startCount = 0;
            var endCount = 0;

            var p = new Fizzy();

            startCount = p.startNumber();
            endCount = p.endNumber();

            // fizz and buzz values
            System.Console.WriteLine("Enter desired divisors:");
            firstCheck = p.divisor();
            secondCheck = p.divisor();

            // check for order
            if (firstCheck > secondCheck)
            {
                var temp = firstCheck;
                firstCheck = secondCheck;
                secondCheck = temp;
            }

            p.runFizzBuzz(startCount, endCount, firstCheck, secondCheck);

            return;
        }

        public int startNumber ()
        {
            var num = 0;
            var input = "";

            System.Console.WriteLine("Enter starting number:");
            input = System.Console.ReadLine();
            if(!(int.TryParse(input, out num))){
                System.Console.WriteLine("Error: value is not an integer!");
                startNumber();
            }
            return num;
        }

        public int endNumber() 
        {
            var num = 0;
            var input = "";

            System.Console.WriteLine("Enter ending number:");
            input = System.Console.ReadLine();
            if(!(int.TryParse(input, out num))) {
                System.Console.WriteLine("Error: value is not an integer!");
                endNumber();
            }
            return num;
        }

        public int divisor() {
            var num = 0;
            var input = "";

            input = System.Console.ReadLine();
            if(!(int.TryParse(input, out num))) 
            {
                System.Console.WriteLine("Error: value is not an integer!");
                divisor();
            }
            return num;
        }

        public void runFizzBuzz(int start, int end, int first, int second) 
        {
            var fizzCount = 0;
            var buzzCount = 0;
            var fizzbuzzCount = 0;


            System.Console.WriteLine();

            // loop
            for (int i = start; i <= end; i += 1)
            {
                // conditionals
                if (i % first == 0 && i % second == 0)
                {
                    fizzbuzzCount += 1;
                    System.Console.WriteLine(_fizzbuzz);
                }
                else if(i % first == 0)
                {
                    fizzCount += 1;
                    System.Console.WriteLine(_fizz);
                }
                else if(i % second == 0)
                {
                    buzzCount += 1;
                    System.Console.WriteLine(_buzz);
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine(fizzCount + " fizzes");
            System.Console.WriteLine(buzzCount + " buzzes");
            System.Console.WriteLine(fizzbuzzCount + " fizzbuzzes");

            return;
        }
    }
}
