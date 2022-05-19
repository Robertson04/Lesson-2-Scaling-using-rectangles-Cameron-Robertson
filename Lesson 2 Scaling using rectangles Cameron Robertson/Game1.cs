using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lesson_2_Scaling_using_rectangles_Cameron_Robertson
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture;
        Texture2D circleTexture2;
        Texture2D circleTexture3;
        Rectangle circleRect;
        Rectangle circleRect2;
        Rectangle circleRect3;
        Texture2D rectangleTexture;
        Rectangle rectangleRect;
        SpriteFont titleFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            circleRect = new Rectangle(250, 100, 300, 300);
            rectangleRect = new Rectangle(320, 170, 150, 50);
            circleRect2 = new Rectangle(300, 250, 80, 80);
            circleRect3 = new Rectangle(400, 250, 80, 80);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            circleTexture2 = Content.Load<Texture2D>("circle");
            circleTexture3 = Content.Load<Texture2D>("circle");
            titleFont = Content.Load<SpriteFont>("Title");
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
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(circleTexture, circleRect, Color.White);
            _spriteBatch.Draw(circleTexture2, circleRect2, Color.Black);
            _spriteBatch.Draw(circleTexture3, circleRect3, Color.Black);
            _spriteBatch.Draw(rectangleTexture, rectangleRect, Color.Black);
            _spriteBatch.DrawString(titleFont, "Is it upside down or are you!", new Vector2(210, 20), Color.Black);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
