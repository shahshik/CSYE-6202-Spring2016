namespace FizzBuzz
{
	public class FizzBuzz
	{
		public string RunFizzBuzz(int number)
		{
			string result = number.ToString();

            // your solution/implementation should go in here
            if (i == 0)
            {
                output = "0";
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                output = "FizzBuzz";
            }
            else if (i % 5 == 0)
            {
                output = "Buzz";
            }
            else if (i % 3 == 0)
            {

                output = "Fizz";
            }
            else
            {
                output = i.ToString();
            }

            return output;
            return result;
		}
	}
}
