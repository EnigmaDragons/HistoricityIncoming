﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using Graphics;
using HistoricityIncoming.Scene;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Sound;

namespace HistoricityIncoming.Views
{
    public class ConversationView : IGameView
    {
        private readonly string _backdropName;
        private readonly Conversation _conversation;
        private readonly Character _leftCharacter;
        private readonly Character _rightCharacter;
        private Texture2D _backdrop;
        private Song _music;

        public ConversationView(string backdropName, Conversation conversation)
        {
            _backdropName = backdropName;
            _conversation = conversation;
            _leftCharacter = conversation.Characters[0];
            _rightCharacter = conversation.Characters[1];
        }

        public void LoadContent()
        {
            _backdrop = new BackdropTexture(_backdropName).Get();
            _conversation.LoadContent();
            _leftCharacter.LoadContent();
            _rightCharacter.LoadContent();
            _music = new LoadedSong("SteampunkFunk").Get();
            MediaPlayer.IsRepeating = true;
            MediaPlayer.Play(_music);
        }

        public void UnloadContent()
        {
            _backdrop?.Dispose();
            _conversation.UnloadContent();
            _leftCharacter?.UnloadContent();
            _rightCharacter?.UnloadContent();
        }

        public void Update(long deltaMillis)
        {
            
        }

        public void Draw()
        {
            new ViewBackgroundColor(Color.Black).Draw();
            new DrawOnScreen(_backdrop, new Vector2(0, 0)).Go();
            _leftCharacter.Draw(new Vector2(10, 265));
            _rightCharacter.Draw(new Vector2(740, 265));
        }
    }
}
