using System;

class Program
{
    static void Main() 
    {
        int choice = 0; 
        while (true) 
        { 
            Console.WriteLine("What type of conversion would you like to do: " + "\n"+ "1. Binary to Decimal" +"\n" + "2. Decimal to Binary");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                bi_to_dec(choice);
                break;
            }
            else if (choice == 2)
            {
                myDec_to_bi(choice);
                break;
            }
            else 
            {
            Console.WriteLine("Please enter 1 or 2"+"\n");
                continue;
            }
        }
   
    }
    static void bi_to_dec(int choice)
    {
        while (true)
        {
            // Ask user to enter a binary number
            Console.WriteLine("Please enter your binary number.It cannot exceed 8 digits");
            string num = Console.ReadLine();

            // Calculate starting power of 2 based on the length of the binary number
            int baseNum = num.Length - 1;// represents the power of 2 for each digit, starting from the leftmost digit at 2^(num.Length - 1)
            double sum = 0;

            // error check: ensure the binary number entered does not exceed 8 digits
            if (num.Length > 8)
            {
                Console.WriteLine("Your binary number must be less than 8 digits" + "\n");
                continue;
            }
            else
            {
                for (int i = 0; i < num.Length; i++)
                {
                    // check if the digit at position i is '1' or '0'
                    // if it is a '1', add 2^baseNum to the sum & if it is a '0', do nothing and continue the loop
                    if (num[i] == '1')
                    {
                        //getting the sum of the conversion
                        sum += Math.Pow(2, baseNum);
                    }
                    else if (num[i] != '1' && num[i] != '0')
                    {
                        // error check: if the digit is not 0 or 1, display an error and prompt again
                        Console.WriteLine("Your binary should only include 1s and 0s" + "\n");
                        goto PromptAgain;
                    }
                    else { }
                    baseNum--;
                }
            }

            // display the result of the binary to decimal conversion
            Console.WriteLine($"Conversion of binary number: \"{num}\" is {sum}");
            break;
        //Going back to asking for input from user if invalid number is detected
        PromptAgain:
            continue;
        }
    }
    static double number;
    static void myDec_to_bi(int choice) 
    {
        int num;
        double qoutient = 0,numType = 0;
        string binary = "";
        while (true)
        {
            Console.WriteLine("Please enter your number.");
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Enter a valid integer");
                continue;
            }
            else 
            {
                number = num;
            break;
            }
        }
        string output = "";


        while (number >=1)
        {
            double remainder = number % 2;
            binary = remainder +binary;
            number = number / 2;
           
        }
       
        Console.WriteLine($"{binary}");

    }
}

