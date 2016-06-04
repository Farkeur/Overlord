using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Overlord
{
    class ScreenManager
    {
        Menu menu;
        GameScreen GS;
        bool isPlaying = false;

        public void Initialize(MouseState ms)
        {
            menu = new Menu();
            GS = new GameScreen();

            GS.Initialize();
            menu.Initialize(ms);
        }
            
        public void LoadContent(ContentManager Content)
        {
            GS.LoadContent(Content);
            menu.LoadContent(Content);
        }

        public void Update(GameTime gameTime, MouseState ms,KeyboardState ks)
        {
            GS.Update(gameTime,ks);
            menu.Update(gameTime, ms);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            GS.Draw(spriteBatch);
            menu.Draw(spriteBatch);               
        }
    }
}
