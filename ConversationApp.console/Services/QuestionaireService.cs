using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationApp.console.Services
{
    class QuestionaireService : Interfaces.IQuestionaire
    {
        /// <summary>
        /// Asks Questions from the Question Bank
        /// which has a list of questions
        /// </summary>
        public void askQuestion()
        {
            foreach (var question in QuestionBank.questions)
            {
                Console.WriteLine(question);
                string answer = Console.ReadLine();
                repeatAnswer(answer);
            }
        }

        /// <summary>
        /// Reapeats the answer to each question
        /// </summary>
        /// <param name="answer"></param>
        public void repeatAnswer(string answer)
        {
            Console.WriteLine($"You answered: {answer}\n");
        }
    }
}
