using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Intro_Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D bunnyTexture;
        private Texture2D grassTexture;
        private Texture2D sunTexture;
        private Texture2D cloudTexture;
        private Rectangle window;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();

            this.Window.Title = "Tiles, Textures And Colours Assignment";


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            bunnyTexture = Content.Load<Texture2D>("bunny");
            grassTexture = Content.Load<Texture2D>("grass");
            sunTexture = Content.Load<Texture2D>("sun");
            cloudTexture = Content.Load<Texture2D>("cloud");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Azure);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(bunnyTexture, new Vector2 (350,350), Color.White);
            _spriteBatch.Draw(grassTexture, new Vector2 (0, 160) , Color.White);
            _spriteBatch.Draw(sunTexture, new Vector2 (600,0) , Color.White);
            _spriteBatch.Draw(cloudTexture, new Vector2 (0,0), Color.White);


            _spriteBatch.End();

            base.Draw(gameTime);

        }
    }
}
