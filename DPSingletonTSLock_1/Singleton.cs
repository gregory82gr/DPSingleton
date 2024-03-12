using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSingletonTSLock_1
{ 
        public sealed class Singleton
        {
            //This variable value will be increment by 1 each time the object of the class is created
            private static int Counter = 0;

            //This variable is going to store the Singleton Instance
            private static Singleton Instance = null;

            //To use the lock, we need to create one variable
            private static readonly object Instancelock = new object();

            //The following Static Method is going to return the Singleton Instance
            public static Singleton GetInstance()
            {
            //This is thread-safe
            //If it is null, we use the lock to ensure only one thread can enter
            //the critical section.
            if (Instance == null)
            {
                //As long as one thread locks the resource, no other thread can access
                //the resource
                //As long as one thread enters into the Critical Section, 
                //no other threads are allowed to enter the critical section
                lock (Instancelock)
                { //Critical Section Start
                  //Within the lock block, we check the null condition to ensure only one instance
                  //of the Singleton Class will be created.
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                } //Critical Section End
                  //Once the thread releases the lock, the other thread allows entering into the critical section
                  //But only one thread is allowed to enter the critical section
            }
                //Return the Singleton Instance
                return Instance;
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
