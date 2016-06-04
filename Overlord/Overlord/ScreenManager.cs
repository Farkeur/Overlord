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
        public Texture2D texture;

        enum GameState
        {
            Menu,
            Option,
            Playing,
        }
        GameState CurrentGameState = GameState.Menu;

        public void Initialize()
        {
            
        }
            
        public void LoadContent(ContentManager Content)
        {
            texture = Content.Load<Texture2D>("Bk");
        }

        public void Update(GameTime gameTime)
        {
             switch (CurrentGameState)
            {
                case GameState.Menu:
                    break;

                case GameState.Playing:
                    break;
            }

            MouseState mouse = Mouse.GetState();

            if (menu.isClicked == true) CurrentGameState = GameState.Playing;
            menu.Update(mouse);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            switch (CurrentGameState)
            {
                case GameState.Menu:
                    menu.Draw(spriteBatch);
                    spriteBatch.Draw(texture,new Rectangle(0, 0,1920,1080), Color.White);
                    break;

                case GameState.Playing:
                    break;
            }
        }
    }
}
