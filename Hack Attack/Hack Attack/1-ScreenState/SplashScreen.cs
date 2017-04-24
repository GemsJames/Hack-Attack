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

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);

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
            }
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
