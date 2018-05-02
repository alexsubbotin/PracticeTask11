using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask11
{
    class Program
    {
        // Task: decrypt binary message each symbol of which occurs 3 times (111000111 decrypts as 101).
        // Student: Alexey Subbotin. Group: SE-17-1.
        static void Main(string[] args)
        {
            // Receiving the message,
            string inputMessage;
            do
            {
                Console.Write("Enter the message: ");
                inputMessage = Console.ReadLine();
                if (inputMessage.Length % 3 != 0)
                    Console.WriteLine("The number of symbols is not a multiple of 3!");
            } while (inputMessage.Length % 3 != 0);

            // Decrypted message.
            string realMessage = "";

            // Decrypting the message.
            for (int i = 0; i < inputMessage.Length; i += 3)
            {
                // The number of zeros in a group of 3.
                int zeroCount = 0;

                // The number of ones in a group of 3.
                int oneCount = 0;

                // Counting ones and zeros.
                for (int j = i; j < i + 3; j++)
                {
                    if (inputMessage[j] == '0')
                        zeroCount++;
                    else
                        oneCount++;
                }

                // Adding to the decrypted the most frequent symbol.
                if (zeroCount > oneCount)
                    realMessage += "0";
                else
                    realMessage += "1";
            }

            Console.WriteLine("Decrypted message: " + realMessage);

            Console.ReadLine();
        }
    }
}
