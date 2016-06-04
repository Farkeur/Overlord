using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

public class Class1
{
	public Class1()
	{

	}

    private Spritefont POLICE;

    protected override void Initialize()
    {
        base.Initialize();
    }


    protected override void LoadContent()
    {
        POLICE = Content.Load<Spritefont>("POLICE");
    }

    protected override void UnloadContent()
    {

    }


    protected override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }


    protected override void Draw(GameTime gameTime)
    {
        spriteBatch.Begin();

        spriteBatch.DrawString(POLICE, "Play", new Vector2(10, 20), Color.White);

        spriteBatch.End();
        base.Draw(gameTime);
    }
}
