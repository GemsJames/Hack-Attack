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
    public class TitleScreen : GameScreen
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
            if (keyState.IsKeyDown(Keys.Enter))                      //stop time clues
                ScreenManager.Instance.AddScreen(new SplashScreen());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            // Texturas
            background = content.Load<Texture2D>("tempbcgrd");

            spriteBatch.Draw(background, new Rectangle(0, 0, 800, 480), Color.White);
            //
        }
    }
}
