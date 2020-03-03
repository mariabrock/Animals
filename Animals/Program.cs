using System;
using Animals.Reptiles;


namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanstaciation
            var americanAlligator = new Alligator(100);
            americanAlligator.IsAquatic = true;

            var africanAlligator = new Alligator(2);
            africanAlligator.IsAquatic = false;

            americanAlligator.Run(75);
            africanAlligator.Run(4);

            americanAlligator.Run(40);
        }
    }
}
