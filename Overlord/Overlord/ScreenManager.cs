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
        bool isPlaying = false;

        public void Initialize(MouseState ms)
        {
            menu = new Menu();
            menu.Initialize(ms);
        }
            
        public void LoadContent(ContentManager Content)
        {
            menu.LoadContent(Content);
        }

        public void Update(GameTime gameTime, MouseState ms)
        {
            menu.Update(gameTime, ms);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            menu.Draw(spriteBatch);
                          
        }
    }
}
