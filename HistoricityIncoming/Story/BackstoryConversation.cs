using System.Collections.Generic;
using HistoricityIncoming.Scene;

namespace HistoricityIncoming.Story
{
    public class BackstoryConversation : Conversation
    {
        private const string HACKER_NAME = "Ji Reilly";
        private const string DETECTIVE_NAME = "Brady";

        public BackstoryConversation() 
            : base(new List<Character> { new Hacker(HACKER_NAME), new Detective(DETECTIVE_NAME) }, 
                  new Script
                  {
                      new ScriptLine(HACKER_NAME, "I guess I'm just the classic example of the man who had every advantage going tragically wrong."),
                      new ScriptLine(DETECTIVE_NAME, "You did."),
                      new ScriptLine(DETECTIVE_NAME, "Ji Reilly. Says here you're a g-mod from birth."), 
                      new ScriptLine(DETECTIVE_NAME, "Mommy and daddy must have loved you very much to tinker with your brain like that."),
                      new ScriptLine(HACKER_NAME, "Oh, sure."),
                      new ScriptLine(HACKER_NAME, "They loved me so much they planned everything out."),
                      new ScriptLine(HACKER_NAME, "You know I was born on Heinlein, but I went to school downstalk."),
                      new ScriptLine(HACKER_NAME, "Mommy and daddy lived on the moon, but there I was, living in an arcology in New Angeles."),
                      new ScriptLine(HACKER_NAME, "I could look out the window at night and wave at my mom and dad."),
                      new ScriptLine(DETECTIVE_NAME, "Don't sell me that line of bull."),
                      new ScriptLine(HACKER_NAME, "It's all there in the file, Detective."),
                      new ScriptLine(HACKER_NAME, "All planned out. Internship with Jinteki's AI research division."),
                      new ScriptLine(HACKER_NAME, "Management position by 25. VP by 30."),
                      new ScriptLine(DETECTIVE_NAME, "You were not a Jinteki VP."),
                      new ScriptLine(HACKER_NAME, "Oh, hell no, can you imagine?"),
                      new ScriptLine(HACKER_NAME, "That company would never survive me."),
                      new ScriptLine(HACKER_NAME, "Still might not."),
                      new ScriptLine(DETECTIVE_NAME, "So you had every goddamn advantage a boy could dream of, and yet here you are."),
                      new ScriptLine(DETECTIVE_NAME, "So why the life of crime, Reilly?"),
                      new ScriptLine(HACKER_NAME, "Why the life of crime."),
                      new ScriptLine(HACKER_NAME, "Why not?"),
                      new ScriptLine(DETECTIVE_NAME, "I know why."),
                      new ScriptLine(DETECTIVE_NAME, "You get plenty rich off these little capers."),
                      new ScriptLine(HACKER_NAME, "There's what you know, and what you think you know, Detective."),
                      new ScriptLine(HACKER_NAME, "And there's two things you should know before we go any further."),
                      new ScriptLine(DETECTIVE_NAME, "Yeah?"),
                      new ScriptLine(HACKER_NAME, "The first thing is that arresting me over and over does not mean that I'm a criminal."),
                      new ScriptLine(HACKER_NAME, "Not until you can find a charge that'll stick."),
                      new ScriptLine(DETECTIVE_NAME, "You're no good, Reilly."),
                      new ScriptLine(DETECTIVE_NAME, "The techs are going to find that stolen data on one of your datacores, somewhere."),
                      new ScriptLine(DETECTIVE_NAME, "You won't be a top-flight runner anymore."),
                      new ScriptLine(DETECTIVE_NAME, "They're gonna pull the cyberware out of your head and if you so much as touch a PAD they'll break your fingers."),
                      new ScriptLine(DETECTIVE_NAME, "You'll just be Ji Reilly."),
                      new ScriptLine(DETECTIVE_NAME, "Nobody."),
                      new ScriptLine(HACKER_NAME, "The other thing, Detective."),
                      new ScriptLine(HACKER_NAME, "My name is Noise."),
                      new ScriptLine(HACKER_NAME, "So, I guess I'll be going now?"),
                  }) { }
    }
}
