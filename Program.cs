using System; 

        
namespace Simple
{ 
    class Program 
    { 
    
            static void Main(string [] aargs) 
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
                 if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");

            } else { 
                Console.WriteLine("Heart rate is not normal."); 
            
            }
            if (deposits>= 100000000){

                Console.WriteLine("You are exceedingly wealthy.");

            }else {

                Console.WriteLine("Sorry you are so poor.");
            }


                    // const char integral = '\u{222B}';
                    // Console.WriteLine(integral);

                    
                    Console.WriteLine("Hello World");


        } 


    } 

    



}  
