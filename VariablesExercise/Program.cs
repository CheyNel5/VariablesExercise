using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string catName = "Meeko";
            int catAge = 2;
            char nickName = 'M';
            bool lovesMice = true;
            double featherMice = 20;
            decimal weight = 8.4m;

            Console.WriteLine($"My cat's name is {catName}, he also goes by {nickName}. He is {catAge} years old and he has {featherMice} feather mice toys and it is {lovesMice } that he loves to play with his toys, which keeps him at a healthy weight of { weight} pounds ");
        }
    }
}
