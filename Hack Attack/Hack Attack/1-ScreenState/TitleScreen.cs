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
        SpriteFont font;
        private Texture2D background;

        public override void LoadContent(ContentManager Content, InputManager inputManager)
        {
            base.LoadContent(Content, inputManager);
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            inputManager.Update();
            if (inputManager.KeyPressed(Keys.Z))                      //stop time clues
                ScreenManager.Instance.AddScreen(new SplashScreen(), inputManager);
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
