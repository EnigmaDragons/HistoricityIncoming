﻿using Engine;
using Microsoft.Xna.Framework.Graphics;

namespace Graphics
{
    public class LoadedTexture
    {
        private readonly string _textureName;
        private const string ImageFolder = "Images/";

        public LoadedTexture(string textureName)
        {
            _textureName = textureName;
        }

        public Texture2D Get()
        {
            return new GameInstance().Load<Texture2D>(ImageFolder + _textureName);
        }
    }
}
