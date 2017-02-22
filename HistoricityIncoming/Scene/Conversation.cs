using System.Collections.Generic;
using Engine;
using Microsoft.Xna.Framework;

namespace HistoricityIncoming.Scene
{
    public class Conversation : IGameObject
    {
        public List<Character> Characters { get; }
        private readonly Script _script;

        private int _scriptIndex = -1;

        public Conversation(List<Character> characters, Script script)
        {
            Characters = characters;
            _script = script;
        }

        public void Advance()
        {
            _scriptIndex++;
            SetActiveCharacter(_script[_scriptIndex].CharacterName);
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
