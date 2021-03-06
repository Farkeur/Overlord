﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Overlord
{
    class GameScreen
    {
        Hero hero;

        public void Initialize()
        {
            hero = new Hero();
        }

        public void LoadContent(ContentManager Content)
        {
            hero.LoadContent(Content);
        }

        public void Update(GameTime gameTime, KeyboardState ks)
        {
            hero.Update(gameTime,ks);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            hero.Draw(spriteBatch);
        }
    }
}
