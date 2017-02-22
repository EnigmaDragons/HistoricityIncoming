using System.Collections.Generic;
using HistoricityIncoming.Scene;

namespace HistoricityIncoming.Story
{
    public class ExtortionConversation : Conversation
    {
        private const string HACKER_NAME = "Ang3l0R0X";
        private const string SCIENTIST_NAME = "Bormann";

        public ExtortionConversation() 
            : base(new List<Character> { new Hacker(HACKER_NAME), new Scientist(SCIENTIST_NAME) }, 
                  new Script
                  {
                      new ScriptLine(HACKER_NAME, "I'm glad I found you here tonight"),
                      new ScriptLine(SCIENTIST_NAME, "Who are you?"),
                  }) { }
    }
}
