using System;

namespace Lab03_Ali
{
    class Program
    {
        static void Main(string[] arg)
        {

            int speedlimit = 35;

            int speed = 42;

            if (speed > speedlimit)
            {

                Console.WriteLine("SLOW DOWN! ");
            }
            int istrue = 10; if
                (istrue <= 60)
                Console.WriteLine("It is True");
            else
                Console.WriteLine("It is False");



            Console.WriteLine("Input temperature in Fahrenheit: ");
            int fah = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int FtoC = ((fah - 32) / 9) * 5;
            Console.WriteLine("Temperature in Celsius is {0}: ", FtoC);
            Console.ReadLine();




            int i = 1;

            while (i < 11) ;
            {
                Console.Write("While Output: ");
                Console.WriteLine(i);
                i++;
            }

            int i = 60;

            while (i >= 20)

                Console.Write("While Output: ");
            Console.WriteLine(i);
            i--;
            int 1 = 10;

            while (i <= 20)
            {
                Console.Write("While Output: ");
                Console.WriteLine(i);
                i++;
            }
            }
        }
    }

      //Question 1: if single and while repetition statements share the similarity in which they must evaluate if a
    //given value is either true or false. Requiring they meet a certain condition in order for them to stop 
  //executing code.They are different because the “if” condition only does what it is told to, then stops. While the
  //while” condition repeats over and over until it hits its loop termination. 








































