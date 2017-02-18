using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Classes
{
    public class Questions
    {
        List<string> QuestionList;  //list used to store questions

        //initializes list and stores questions into list
        public Questions()
        {
            QuestionList = new List<string>();
            QuestionList.Insert(0, "1. Who is Kanye West married to?");
            QuestionList.Insert(1, "2. How many children does he have?");
            QuestionList.Insert(2, "3. Where was Kanye West born?");
            QuestionList.Insert(3, "4. What is his occupation?");
            QuestionList.Insert(4, "5. What genre of music does he produce?");
            QuestionList.Insert(5, "6. Which record label did West find?");
            QuestionList.Insert(6, "7. 'Damn, they don't make 'em like this anymore' is from which song?");
            QuestionList.Insert(7, "8. In 2007, which member of West's family passed away?");
            QuestionList.Insert(8, "9. What is the name of West's first album release?");
            QuestionList.Insert(9, "10. What is the name of West's 2016 album?");
            QuestionList.Insert(10, "11. 'She got one of your kids, got you for 18 years' is from which song?");
            QuestionList.Insert(11, "12. Who did West collaborate with to produce the album 'Watch the Throne'?");
            QuestionList.Insert(12, "13. In the 2009 MTV Video Music Awards, who did West interrupt during an award speech?");
            QuestionList.Insert(13, "14. Which company does West collaborate with for his clothing line?");
            QuestionList.Insert(14, "15. What is his clothing line called?");
        }

        //retrieves questions from list
        public string getQuestion(int questionNumber)
        {
            return QuestionList[questionNumber];
        }
    }
}