namespace H1_Extra_Travel_insurance
{
    internal class Program
    {
        static void Main()
        {
            Controller();
        }

        #region Controllers

        static void Controller()
        {
            // Infinite loop
            while (true)
            {
                // Clears the console for each new loop
                Console.Clear();

                // Outputs a message using the Message method
                Message("Write your social security number");

                // Creates a char array for the user input and takes in the input fromn the user
                char[] input = Console.ReadLine().ToCharArray();

                // Checks if the user input length is valid, if not then output a message and repeat loop
                if (input.Length != 10)
                {
                    Message("Social security number has to be 10 characters long!\nPress enter to try again!");
                    Console.ReadLine();
                    continue;
                }

                // Checks if the characters inside the input char array is valid, based on the IsValidCharacters method,
                // if not output a message and start the loop over
                if (!IsValidCharacters(input))
                {
                    Message("Characters are not valid!\nPress enter to try again!");
                    Console.ReadLine();
                    continue;
                }

                // Creates a new array for converting char into int
                int[] values = new int[input.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = Convert.ToInt32(input[i].ToString());
                }

                // Creates an array for the weight, which are predetermined numbers
                int[] weight = { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };

                // Creates an empty array for the result of value[i] * weight[i] and then runs the equation in a for loop
                int[] calculation = new int[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    calculation[i] = values[i] * weight[i];
                }

                // Creates a new variable called result and then adds each value in the calculation array together inside the result variable
                int result = 0;
                foreach (int number in calculation)
                {
                    result += number;
                }

                // Uses modulus to figure out if the SSN is valid, then it outputs the appropriate message
                if (result % 11 == 0)
                {
                    Message("Valid social security number\nPress enter to try again!");
                } else
                {
                    Message("Invalid social security number\nPress enter to try again!");
                }

                Console.ReadLine();
            }
        }

        static bool IsValidCharacters(char[] input)
        {
            // String containing the valid characters
            string valid = "1234567890";

            // Runs through each character in the input and checks if it has a character that doesnt contain any of the characters in the valid string
            // If any character is not inside the valid string, then it returns false, else true.
            for(int i  = 0; i < input.Length; i++)
            {
                if (!valid.Contains(input[i]))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region Views

        static void Message(string message)
        {
            // Writes whatever is written when the method is called
            Console.WriteLine(message);
        }

        #endregion
    }
}