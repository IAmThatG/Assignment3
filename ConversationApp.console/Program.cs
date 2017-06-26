using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationApp.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Interfaces.IQuestionaire questionaire = new Services.QuestionaireService();
            questionaire.askQuestion();
            Console.ReadKey();
        }
    }
}
