﻿
namespace HistoricityIncoming.Scene
{
    public class ScriptLine
    {
        public string CharacterName { get; }
        public string Text { get; }

        public ScriptLine(string characterName, string text)
        {
            CharacterName = characterName;
            Text = text;
        }
    }
}
