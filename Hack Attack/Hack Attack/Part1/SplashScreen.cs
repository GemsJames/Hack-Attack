using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Hack_Attack
{
    public class SplashScreen : GameScreen
    {
        KeyboardState keyState;
        SpriteFont font;
        private Texture2D background;

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Z))                      //stop time clues
                ScreenManager.Instance.AddScreen(new TitleScreen());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            background = content.Load<Texture2D>("tempsplash");

            spriteBatch.Draw(background, new Rectangle(0, 0, 800, 480), Color.White);
        }
    }
}
