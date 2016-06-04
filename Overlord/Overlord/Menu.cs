using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace Overlord
{
    class Menu
    {
        private SpriteFont POLICE;

        public virtual void Initialize()
        {
            
        }


        public virtual void LoadContent(ContentManager Content)
        {
            POLICE = Content.Load<SpriteFont>("POLICE");
        }

        public virtual void UnloadContent()
        {

        }


        public virtual void Update(GameTime gameTime)
        {
            
        }


        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.DrawString(POLICE, "PLAY", new Vector2(10, 20), Color.White);

            spriteBatch.End();



        }
    }
}
