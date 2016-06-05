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

        
        
        bool front = false;
        bool back = false;
        bool left = false;
        bool right = false;

        float speed = 0.5f;

        public void Initialize()
        {
            
        }

        public void LoadContent(ContentManager Content)
        {
            h1 = Content.Load<Texture2D>("Hero/HeroFront1");
            h2 = Content.Load<Texture2D>("Hero/HeroFront2");
            h3 = Content.Load<Texture2D>("Hero/HeroLeft1");
            h4 = Content.Load<Texture2D>("Hero/HeroRight1");
        }

        public void Update(GameTime gameTime, KeyboardState ks)
        {
            
            

            if (ks.IsKeyDown(Keys.Up))
            {
                back = true;
                front = false;
                left = false;
                right = false;
                h1position.Y -= speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
            if (ks.IsKeyDown(Keys.Down))
            {
                 front = true;
                back = false;
                left = false;
                right = false;
                h1position.Y += speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
            if (ks.IsKeyDown(Keys.Left))
            {
                left = true;
                right = false;
                front = false;
                back = false;
                h1position.X -= speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
            if (ks.IsKeyDown(Keys.Right))
            {
                right = true;
                front = false;
                back = false;
                left = false;
                h1position.X += speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
            if (front == true)
            {
                spriteBatch.Draw(h1, h1position, null,Color.White, 0f, Vector2.Zero, 0.1f, SpriteEffects.None, 0f);
            }
            else if (back == true)
            {
                spriteBatch.Draw(h2, h1position,null, Color.White,0f, Vector2.Zero, 0.1f,SpriteEffects.None, 0f);
            }
            else if (left == true)
            {
                spriteBatch.Draw(h3, h1position,null, Color.White,0f ,Vector2.Zero,0.1f,SpriteEffects.None, 0f);
            }
            else if (right == true)
            {
                spriteBatch.Draw(h4, h1position,null, Color.White, 0f, Vector2.Zero, 0.1f,SpriteEffects.None, 0f);
            }
            
        }
    }
}
