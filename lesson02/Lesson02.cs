using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace lesson02
{
    public class lesson02 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont _arial;
        private const int _WindowWidth = 640;
        private const int _WindowHeight = 320;
        private float _y = 0;
        private float _amoutToAddToX = 4;
        private float _x = 0;
        private float _amoutToAddToY = 4;



        private string _output = "Hello is anyone out there";
        public lesson02()
        {
            this._graphics = new GraphicsDeviceManager(this);
            base.Content.RootDirectory = "Content";
            base.IsMouseVisible = true;
         

        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = _WindowWidth;
            _graphics.PreferredBackBufferHeight = _WindowHeight;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _arial = Content.Load<SpriteFont>("SystemArialFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            Vector2 stringDimeation = _arial.MeasureString(_output);
            _x += _amoutToAddToX;
            if (_x < 0) 
            {
                _amoutToAddToX += -1;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DeepPink);
           

            _spriteBatch.Begin();
            _spriteBatch.DrawString(_arial, _output, new Vector2(_x, 0), Color.PeachPuff);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}