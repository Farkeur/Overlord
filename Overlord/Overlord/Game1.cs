using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Overlord
{
    
    public class Game1 : Game
    {

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Menu menu;
        ScreenManager screenmanager;


        int screenHeight = 1920;
        int screenWidth = 1080;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            
            Content.RootDirectory = "Content";
        }
        
        protected override void Initialize()
        {    
            base.Initialize();
            screenmanager = new ScreenManager();
        }

        
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;
            //graphics.IsFullScreen = true;
            graphics.ApplyChanges();
            IsMouseVisible = true;

            menu = new Menu(Content.Load<Texture2D>("play-button"), graphics.GraphicsDevice);
            menu.setPosition(new Vector2(750, 600));
        }
         
        protected override void UnloadContent()
        { 
            ;
        }

        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

                screenmanager.Update(gameTime);

                base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();          
            
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
