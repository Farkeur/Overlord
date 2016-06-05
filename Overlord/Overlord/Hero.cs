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
    class Hero
    {
        private Texture2D h1;
        private Texture2D h2;
        private Texture2D h3;
        private Texture2D h4;

        private Vector2 h1position;

        
        Game1 game;
        bool front = false;
        bool back = false;
        bool left = false;
        bool right = false;

        float speed = 1;

        public void Initialize()
        {
            
        }

        public void LoadContent(ContentManager Content)
        {
            h1 = Content.Load<Texture2D>("Hero/HeroFront1");
            h2 = Content.Load<Texture2D>("Hero/HeroFront2");
            h3 = Content.Load<Texture2D>("Hero/HeroLeft1");
            h4 = Content.Load<Texture2D>("Hero/HeroRight2");
        }

        public void Update(GameTime gameTime, KeyboardState ks)
        {
            ks = Keyboard.GetState();
            

            if (ks.IsKeyDown(Keys.Up))
            {
                back = true;
                h1position.Y += speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
            if (ks.IsKeyDown(Keys.Down))
            {
                 front = true;
                h1position.Y -= speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
            if (ks.IsKeyDown(Keys.Left))
            {
                left = true;
                h1position.X -= speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
            if (ks.IsKeyDown(Keys.Right))
            {
                right = true;
                h1position.X += speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
            if (front == true)
            {
                spriteBatch.Draw(h1, Vector2.Zero, Color.White);
            }
            if (back == true)
            {
                spriteBatch.Draw(h2, Vector2.Zero, Color.White);
            }
            if (left == true)
            {
                spriteBatch.Draw(h3, Vector2.Zero, Color.White);
            }
            if (right == true)
            {
                spriteBatch.Draw(h4, Vector2.Zero, Color.White);
            }
            //spriteBatch.Draw(h1, Vector2.Zero, Color.White);
            //spriteBatch.Draw(h2, Vector2.Zero, Color.White);
            // spriteBatch.Draw(h3, Vector2.Zero, Color.White);
            // spriteBatch.Draw(h4, Vector2.Zero, Color.White);
        }
    }
}
