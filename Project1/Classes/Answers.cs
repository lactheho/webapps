using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Classes
{
    public class Answers
    {
        List<string> answersList;   //list to store correct answers

        //initializes list and stores correct answers into list
        public Answers()
        {
            answersList = new List<string>();
            answersList.Insert(0, "Kim Kardashian");
            answersList.Insert(1, "Two");
            answersList.Insert(2, "Alanta, Georgia");
            answersList.Insert(3, "All the Above");
            answersList.Insert(4, "Hip-Hop");
            answersList.Insert(5, "GOOD Music");
            answersList.Insert(6, "Stronger");
            answersList.Insert(7, "Mother");
            answersList.Insert(8, "The College Dropout");
            answersList.Insert(9, "The Life of Pablo");
            answersList.Insert(10, "Gold Digger");
            answersList.Insert(11, "Jay Z");
            answersList.Insert(12, "Taylor Swift");
            answersList.Insert(13, "Adidas");
            answersList.Insert(14, "YEEZY");
        }

        //retrieves correct answer from list
        public string getAnswer(int questionNumber)
        {
            return answersList[questionNumber];
        }

        //compares user's answers with correct answers, returns true or false
        public bool checkAnswer(int questionNumber, string userAnswer)
        {
            if (userAnswer == answersList[questionNumber])
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}