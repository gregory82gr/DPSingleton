using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSingletonTSEager
{
    
        public sealed class Singleton
        {
            //This variable value will be increment by 1 each time the object of the class is created
            private static int Counter = 0;

            //This variable is going to store the Singleton Instance
            //Initiazling the Variable at the time of class start-up and make it ready to be used in Future
            private static readonly Singleton singleInstance = new Singleton();

            //The following Static Method is going to return the Singleton Instance
            //This is Thread-Safe as it use Eager Loading
            public static Singleton GetInstance()
            {
                //Now we don't need to use any NULL Checking code
                //We don't need to write Explicit code for thread-safety
                //Object initialization and Thread-Safety will be taken care by CLR as we are using Eager Loading
                //Return the Singleton Instance
                return singleInstance;
            }

            private Singleton()
            {
                //Each Time the Constructor is called, increment the Counter value by 1
                Counter++;
                Console.WriteLine("Counter Value " + Counter.ToString());
            }

            //The following method can be accessed from outside of the class by using the Singleton Instance
            public void PrintDetails(string message)
            {
                Console.WriteLine(message);
            }
        }
    
}
