namespace FizzBuzzProject
{
    class FizzBuzz
    {
        int amount;
        public FizzBuzz(int amount)
        {
            this.amount = amount; // Set the initial value for model
        }

        public void showFizzBuzz()
        {
            for (int i = 1; i <= amount; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}


