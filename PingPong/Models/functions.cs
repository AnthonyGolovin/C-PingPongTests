using System;

namespace function
{
    public class PingPong
    {

        public string Pingy(int index)
        {


            // Console.WriteLine("Enter a number.");
            // string stringReadNumber = Console.ReadLine();
            // int readNumber = int.Parse(stringReadNumber);

            for (int index = 1; index <= readNumber; index++)
            {
                if (index % 15 == 0)
                {
                    Console.WriteLine("ping-pong");
                }
                else if (index % 5 == 0)
                {
                    Console.WriteLine("pong");
                }
                else if (index % 3 == 0)
                {
                    Console.WriteLine("ping");
                }
                else
                {
                    Console.WriteLine(index);
                }
            }
        }
    }
}