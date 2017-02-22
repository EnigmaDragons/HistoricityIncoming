using Engine;
using Graphics;
using HistoricityIncoming.Scene;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HistoricityIncoming.Views
{
    public sealed class MainMenuView : IGameView
    {
        private INavigation _navigation;
        private Texture2D _backdrop;
        private bool _enterKeyPressed;

        public void LoadContent()
        {
            _backdrop = new BackdropTexture("mainmenu").Get();
        }

        public void UnloadContent()
        {
            _backdrop?.Dispose();
        }

        public void Update(long deltaMillis)
        {
            var ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.Enter) && !_enterKeyPressed)
                _navigation.NavigateTo(new CityScapeSceneView());
            _enterKeyPressed = ks.IsKeyDown(Keys.Enter);
        }

        public void Draw()
        {
            new ViewBackgroundColor(Color.Black).Draw();
            new DrawOnScreen(_backdrop, new Vector2(0, 0)).Go();
            new DrawTextOnScreen("Press ENTER to begin", new Vector2(335, 350), Color.White).Go();
        }

        public void SetNavigaton(INavigation navigation)
        {
            _navigation = navigation;
        }
    }
}
