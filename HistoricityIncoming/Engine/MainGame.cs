using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Engine
{
    public class MainGame : Game, INavigation
    {
        private SpriteBatch _sprites;
        private IGameView _currentView;
        private readonly GraphicsDeviceManager _graphicsManager;

        public MainGame(IGameView startingView, ScreenSize screenSize)
        {
            _graphicsManager = new GraphicsDeviceManager(this);
            screenSize.Apply(_graphicsManager);
            Content.RootDirectory = "Content";
            startingView.SetNavigaton(this);
            _currentView = startingView;
        }

        protected override void Initialize()
        {
            _graphicsManager.IsFullScreen = true;
            IsMouseVisible = true;
            _sprites = new SpriteBatch(GraphicsDevice);
            new GameInstance().SetGame(this);
            new SpritesBatchInstance().SetSpritesBatch(_sprites);
            DefaultFont.Load(Content);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            IsMouseVisible = true;
            _currentView?.LoadContent();
        }

        protected override void UnloadContent()
        {
            Content.Unload();
            _currentView?.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _currentView?.Update(gameTime.ElapsedGameTime.Milliseconds);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _sprites.Begin();
            _currentView?.Draw();
            _sprites.End();
            base.Draw(gameTime);
        }

        public void NavigateTo(IGameView view)
        {
            view.SetNavigaton(this);
            view.LoadContent();
            _currentView?.UnloadContent();
            _currentView = view;
        }
    }
}
