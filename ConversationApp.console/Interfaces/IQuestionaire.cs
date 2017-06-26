using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationApp.console.Interfaces
{
    interface IQuestionaire
    {
        void askQuestion();
        void repeatAnswer(string answer);
    }
}
