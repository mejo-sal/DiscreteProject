using System;


namespace prime_and_perfect_code
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            //this project have been made by :
            //amjed
            //arsany
            //janna

            Console.WriteLine("\t \t \t \t \t Welcome to prime and perfect code \n ");

            Console.WriteLine("For prime numbers program press 1 \nFor perfect number programs press 2 ");

            //Choose the running program
            int chs = Convert.ToInt32(Console.ReadLine());
            //In case of prime numbers
           
            if (chs == 1)
            {
                Console.WriteLine("\t \t prime number program \n ");

                Console.Write("please enter the start value :  ");
                //Input start value
                int start = Convert.ToInt32(Console.ReadLine());

                Console.Write("please enter the end value :  ");
                //Input end value
                int end = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                // Neglect the negative valus
                if (start < 0 || end < start)
                {
                    Console.WriteLine("NOT VALID NUMBERS");


                }



                for (int i = start; i <= end; i++)
                {
       
                    // Neglect the one
                    if (i <2)
                    {
                        continue;
                    }

                    //Assume every number is prime
                    bool prime = true;
                    //loop for numbers
                    for (int j = 2; j <= (i/2); j++)
                    {
                        // if the reminder = 0 make it false
                        if (i % j == 0 && i > j)

                        {

                            prime = false;
                            break;
                        }

                    }
                    // always have a remainder then the number is prime 
                    if (prime)
                    {
                        Console.WriteLine("{0} is Prime number", i);
                    }
                }




                Console.Write("\n");
                 


                //perfect number code
            }
            else if (chs == 2)

            {
                Console.WriteLine("\t \t perfect number program \n ");

                Console.Write("please enter the start value :  ");
                //Input start value
                int start = Convert.ToInt32(Console.ReadLine());

                Console.Write("please enter the end value :  ");
                //Input end value
                int end = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();



               // counting from start to end (n to n ) 
                for (int i = start; i <= end; i++)
                {
                    //neglect zero
                    if (i == 0)
                    {
                        continue;
                    }
                    int sum = 0;
                    // finding the factors 
                    for (int j = 1; j <= (i/2) ; j++)
                    {
                        
                        // if the suming of the factor is bigger then the num break 
                        if (sum > i)
                        {
                            break;
                        }
                        
                        if (i % j == 0)
                        {
                            sum += j ;
                        }
                        

                    }
                    // if the sum = the number then its a perfect num
                    if (sum == i)
                    {
                        Console.WriteLine("{0} is a perfect number ", i);
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("not valid please try again ");
                
           
            }
            Console.ReadKey();
        
        }

    }
}
