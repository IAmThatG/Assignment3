using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationApp.console
{
    static class QuestionBank
    {
        /// <summary>
        /// A list of questions in the question bank
        /// </summary>
        public static IList<string> questions = new List<string>
        {
            "What is your name?",
            "How old are you",
            "What state in Nigeria are you from",
            "What's your favourite color",
            "What's your favourite food"
        };
    }
}
