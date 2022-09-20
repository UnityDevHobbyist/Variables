using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables!");

            // variables

            // integers (whole numbers)
            int score; // declaration -- declare "score" is an integer
            score = 0; // initialization -- init. "score" to be 0.
            int enemyPoints;
            enemyPoints = 50; // 50 pts per kill
            //score = 1000000;
            score = score + enemyPoints; // enemy killed
            Console.WriteLine("Score: " + score); // display score
            Console.WriteLine(score); // display score

            // floating points
            float lapTime; // declaration
            lapTime = 0.0f;
            Console.WriteLine(lapTime); // display score
            lapTime = 65.357f;
            Console.WriteLine(lapTime); // display score

            // string (text)
            string title; // declaration
            title = "Newbie";
            Console.WriteLine(title);
            title = "Pro";
            Console.WriteLine(title);

            Console.ReadKey(true); // wait for keypress
        }
    }
}
