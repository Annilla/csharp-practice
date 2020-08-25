using System;
using System.Collections;

namespace Sec4Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList Version
            ArrayList student = new ArrayList();
            ArrayList score = new ArrayList();
            ArrayList sortScore = new ArrayList();
            string keyName;
            int keyScore;
            int total = 0;
            int average = 0;

            do{
                Console.WriteLine("Enter student's name or press 'Q' to exit.");
                keyName = Console.ReadLine();

                if(keyName != "Q") {
                    student.Add(keyName);
                    Console.WriteLine("Enter {0}'s score.", keyName);
                    keyScore = int.Parse(Console.ReadLine());
                    score.Add(keyScore);
                    sortScore.Add(keyScore);
                }
                

            } while (keyName != "Q");

            sortScore.Sort(); 

            for(int i = 0; i < score.Count ; i++) {
                if(Convert.ToInt32(sortScore[score.Count-1]) == Convert.ToInt32(score[i])) {
                    Console.WriteLine("Highest grade is {0} {1}.", student[i], sortScore[score.Count-1]);
                }
                total = total + Convert.ToInt32(score[i]);
            }

            average = total / (score.Count);

            Console.WriteLine("Average grade is {0}.", average);
        }
    }
}
