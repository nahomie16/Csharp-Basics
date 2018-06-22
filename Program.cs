using System; 

namespace Simple
{
    class Program
    {
        static void Main(string[] aargs)
        {
            byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800F;
            float mass = 14.6F;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const string greeting = "Hello";
            string name = "Karen";
               

            float force = mass * acceleration;

            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }

            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }

            const char integral = '\u222B';
            // “\u{222B}”won't run, must remove curly braces {} 


            Console.WriteLine("force = {0} ", force);
            Console.WriteLine("{0} is the distance.", distance);


            if (lost == true && expensive == true)
            {

                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost == true && expensive == false) {
                Console.WriteLine("Here is coupon for 10% off."); 
            
            }
            else {
                Console.WriteLine("Sorry");
            }
            switch (choice) { 
            
                case 1:
                    Console.WriteLine("You chose 1"); 
                    break; 
                case 2:
                    Console.WriteLine("You chose 2"); 
                    break; 

                case 3:
                    Console.WriteLine("You chose 3"); 
                    break; 

                default:
                    Console.WriteLine("You made an unknown choice"); 
                    break; 
            
            }
            Console.WriteLine(integral);

            for (int i = 5; i < 11; i++) {
                Console.WriteLine("i = {0}", i); 
            }


            int age = 0; 

            while(age < 6) { 
                Console.WriteLine("age = {0}", age);
                age++; 
            
            }
            Console.WriteLine(greeting + " " +  name ); 
        }
    }
}
