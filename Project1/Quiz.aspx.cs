using Project1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Project1
{
    public partial class Quiz : System.Web.UI.Page
    {
        Questions questions = new Questions();          //instance of question object
        Answers answers = new Answers();                //instance of answer object
        List<string> userAnswers = new List<string>();  //list used to store user's answers
        int score = 0;                                  //quiz score counter

        protected void Page_Load(object sender, EventArgs e)
        {
            retrieveAnswers();          //gets all answers from submitted html page

            //change the text of labels to display question, correct answer, and user answer
            lblQuestion1.Text = questions.getQuestion(0) + " " + displayAnswer(0);
            lblQuestion2.Text = questions.getQuestion(1) + " " + displayAnswer(1);
            lblQuestion3.Text = questions.getQuestion(2) + " " + displayAnswer(2);
            lblQuestion4.Text = questions.getQuestion(3) + " " + displayAnswer(3);
            lblQuestion5.Text = questions.getQuestion(4) + " " + displayAnswer(4);
            lblQuestion6.Text = questions.getQuestion(5) + " " + displayAnswer(5);
            lblQuestion7.Text = questions.getQuestion(6) + " " + displayAnswer(6);
            lblQuestion8.Text = questions.getQuestion(7) + " " + displayAnswer(7);
            lblQuestion9.Text = questions.getQuestion(8) + " " + displayAnswer(8);
            lblQuestion10.Text = questions.getQuestion(9) + " " + displayAnswer(9);
            lblQuestion11.Text = questions.getQuestion(10) + " " + displayAnswer(10);
            lblQuestion12.Text = questions.getQuestion(11) + " " + displayAnswer(11);
            lblQuestion13.Text = questions.getQuestion(12) + " " + displayAnswer(12);
            lblQuestion14.Text = questions.getQuestion(13) + " " + displayAnswer(13);
            lblQuestion15.Text = questions.getQuestion(14) + " " + displayAnswer(14);
            lblScore.Text = "Your score: " + score + "/15";         //displays quiz score results

        }

        //uses compare method, if answers match then score increments
        //displays both correct and user answers
        public string displayAnswer(int questionNumber)
        {
            if (answers.checkAnswer(questionNumber, getUserAnswer(questionNumber)))
            {
                score++;
            }
            string display = "Your answer: " + getUserAnswer(questionNumber) + ","
                           + "\n Correct answer: " + answers.getAnswer(questionNumber);

            return display;

        }

        //retrieves all answer values from html page and stores them into the list
        public void retrieveAnswers()
        {
            string question1 = Request["question1"];
            string question2 = Request["question2"];
            string question3 = Request["question3"];
            string question4 = Request["question4"];
            string question5 = Request["question5"];
            string question6 = Request["question6"];
            string question7 = Request["question7"];
            string question8 = Request["question8"];
            string question9 = Request["question9"];
            string question10 = Request["question10"];
            string question11 = Request["question11"];
            string question12 = Request["question12"];
            string question13 = Request["question13"];
            string question14 = Request["question14"];
            string question15 = Request["question15"];

            userAnswers.Insert(0, question1);
            userAnswers.Insert(1, question2);
            userAnswers.Insert(2, question3);
            userAnswers.Insert(3, question4);
            userAnswers.Insert(4, question5);
            userAnswers.Insert(5, question6);
            userAnswers.Insert(6, question7);
            userAnswers.Insert(7, question8);
            userAnswers.Insert(8, question9);
            userAnswers.Insert(9, question10);
            userAnswers.Insert(10, question11);
            userAnswers.Insert(11, question12);
            userAnswers.Insert(12, question13);
            userAnswers.Insert(13, question14);
            userAnswers.Insert(14, question15);
        }

        //gets user's answer from list
        public string getUserAnswer(int questionNumber)
        {
            return userAnswers[questionNumber];
        }

    }
}