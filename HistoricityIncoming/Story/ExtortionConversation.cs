using System.Collections.Generic;
using HistoricityIncoming.Scene;
using HistoricityIncoming.UI;

namespace HistoricityIncoming.Story
{
    public class ExtortionConversation : Conversation
    {
        private const string HACKER_NAME = "Ang3l0R0X";
        private const string SCIENTIST_NAME = "Bormann";

        public ExtortionConversation(ChatBox chatBox) 
            : base(new List<Character> { new Hacker(HACKER_NAME), new Scientist(SCIENTIST_NAME) }, 
                  new Script
                  {
                      new ScriptLine(HACKER_NAME, "I'm glad I found you here tonight"),
                      new ScriptLine(SCIENTIST_NAME, "Who are you?"),
                      new ScriptLine(HACKER_NAME, "I am the all powerful warmonger of the ages out to destroy all robotics and the internet by ripping out it's still beating heart and using to fuel my computer. no one can stop me muhahahahahahahahaha... but don't think you can stop me you weakling of a human I made you who you are and trust me I know your weaknesses")
                  }, chatBox) { }
    }
}
