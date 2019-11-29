using System;

namespace reaktionsspelet
{
    public class Program
    {

        static void Main(string[] args)
        {
            
            var random = new Random();
            var game =  new Game();

            var number = random.Next(3, 10) * 1000;

            game.Play(number);

        }
        
    }
}
