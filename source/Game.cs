using System;
using System.Threading;


namespace reaktionsspelet
{
    public class Game
    {
        public int start;
        
        public void Play(int number){
            start = Environment.TickCount;
            var go = start + number;

            Console.WriteLine("Ok, get ready...");
            while(!NotYet(go)){
                if(Console.KeyAvailable == true){
                    Console.WriteLine("Du fuskade!");
                    return;
                }
            }

            Thread.Sleep(number);
            
            Console.WriteLine("NOW");
            start = Environment.TickCount;
            while(NotYet(go)){
                if(Console.KeyAvailable == true){
                    Console.WriteLine("Det tog {0} milisekunder", Environment.TickCount - start);
                    return;
                }
            }
        }

        public static bool NotYet(int go){
            return (Environment.TickCount >= go) ? true : false;
        }

    }
}
