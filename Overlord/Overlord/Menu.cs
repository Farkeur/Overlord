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
        private SpriteFont TITRE;
        private SpriteFont OPTION;
        bool isPlaying = false;
        public bool isclicked = false;

        public virtual void Initialize(MouseState ms)
        {

        }

        public virtual void LoadContent(ContentManager Content)
        {
            POLICE = Content.Load<SpriteFont>("POLICE");
            TITRE = Content.Load<SpriteFont>("TITRE");
            OPTION = Content.Load<SpriteFont>("Indi");
        }

        public virtual void UnloadContent()
        {

        }

        public virtual void Update(GameTime gameTime, MouseState ms)
        {

            if ( ms.X >925 && ms.X <1060 && ms.Y >590 && ms.Y <640 && ms.LeftButton == ButtonState.Pressed)
            {
                isPlaying = true;
            }
            else
            {
                isPlaying = false;
            }
        }

        public virtual void Draw( SpriteBatch spriteBatch)
        {
            if (isPlaying == false)
            {
                spriteBatch.DrawString(POLICE, "PLAY", new Vector2(925, 600), Color.Black);
                spriteBatch.DrawString(TITRE, "TITRE AU PIF", new Vector2(720, 50), Color.Black);
                spriteBatch.DrawString(OPTION, "Option", new Vector2(950, 700), Color.Black);
            }
        }
    }
}
