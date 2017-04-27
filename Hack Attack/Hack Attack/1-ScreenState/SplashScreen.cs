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
        List<FadeAnimation> fade;
        List<Texture2D> images;

        FileManager fileManager;

        int imageNumber;

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);

            imageNumber = 0;
            fileManager = new FileManager();
            fade = new List<FadeAnimation>();
            images = new List<Texture2D>();

            fileManager.LoadContent("Load/Splash.cme", attributes, contents);

            for(int i=0; i<attributes.Count; i++)
            {
                for(int j=0; j<attributes[i].Count; j++)
                {
                    switch (attributes[i][j])
                    {
                        case "Image":
                            images.Add(content.Load<Texture2D>(contents[i][j]));
                            fade.Add(new FadeAnimation());
                            break;
                    }
                }
            }
            for (int i = 0; i < fade.Count; i++)
            {
                fade[i].LoadContent(content, images[i], "", Vector2.Zero);
                fade[i].Scale = 1.25f;
                fade[i].IsActive = true;
            }
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
            fileManager = null;
        }

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();
            //if (keyState.IsKeyDown(Keys.Z))                      //stop time clues
            //    ScreenManager.Instance.AddScreen(new TitleScreen());

            fade[imageNumber].Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            fade[imageNumber].Draw(spriteBatch);
        }
    }
}
