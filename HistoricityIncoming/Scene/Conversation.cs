using System;
using System.Collections.Generic;
using System.Linq;
using Engine;
using HistoricityIncoming.UI;
using Microsoft.Xna.Framework;

namespace HistoricityIncoming.Scene
{
    public class Conversation : IGameObject
    {
        public List<Character> Characters { get; }
        private readonly Script _script;
        private readonly ChatBox _chatBox;

        private int _scriptIndex = -1;

        public Conversation(List<Character> characters, Script script, ChatBox chatBox)
        {
            Characters = characters;
            _script = script;
            _chatBox = chatBox;
        }

        public void Advance()
        {
            if (_scriptIndex == _script.Count - 1)
                Environment.Exit(0);

            _scriptIndex++;
            var line = _script[_scriptIndex];
            SetActiveCharacter(line.CharacterName);
            _chatBox.Show(line, Characters.IndexOf(Characters.First(x => x.Name.Equals(line.CharacterName))) == 0 ? Side.Left : Side.Right);
        }

        private void SetActiveCharacter(string characterName)
        {
            Characters.ForEach(x => x.CharacterIsTalking(characterName));
        }

        public void LoadContent()
        {
            Characters.ForEach(x => x.LoadContent());
            Advance();
        }

        public void UnloadContent()
        {
            Characters.ForEach(x => x.UnloadContent());
        }

        public void Update(long deltaMillis)
        {
        }

        public void Draw(Vector2 offset)
        {
        }
    }
}
