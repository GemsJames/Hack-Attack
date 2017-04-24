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
    public class ScreenManager
    {
        #region Variables

        //Cria contentManager

        ContentManager content;

        //Ecrã atual

        GameScreen currentScreen;

        //Novo Ecrã

        GameScreen newScreen;

        //ScreenManager Instance

        private static ScreenManager instance;

        //Screen Stack

        Stack<GameScreen> screenStack = new Stack<GameScreen>();

        //Tamanho do Ecrã

        Vector2 dimensions;

        //Deixa saber se é pra tranzecionar

        bool transition;

        FadeAnimation fade;

        Texture2D fadeTexture;

        #endregion

        #region Properties 

        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScreenManager();
                return instance;
            }
        }
        public Vector2 Dimensions
        {
            get { return dimensions; }
            set { dimensions = value; }
        }

        #endregion

        #region Main Methods

        public void AddScreen(GameScreen screen)
        {
            transition = true;
            newScreen = screen;
            fade.IsActive = true;
            fade.Alpha = 0.0f;
            fade.ActivateValue = 1.0f;
        }

        public void Initialize()
        {
            currentScreen = new SplashScreen();
            fade = new FadeAnimation();
        }
        public void LoadContent(ContentManager Content)
        {
            content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent(Content);

            fadeTexture = content.Load<Texture2D>("PixelPreto");
            fade.LoadContent(content, fadeTexture, "", Vector2.Zero);
            fade.Scale = dimensions.X;
        }
        public void Update(GameTime gameTime)
        {
            if (!transition)
                currentScreen.Update(gameTime);
            else
                Transition(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
            if (transition)
                fade.Draw(spriteBatch);
        }

        #endregion

        #region Private Methods

        private void Transition(GameTime gameTime)
        {
            fade.Update(gameTime);
            if(fade.Alpha == 1.0f && fade.Timer.TotalSeconds == 1.0f)
            {
                screenStack.Push(newScreen);
                currentScreen.UnloadContent();
                currentScreen = newScreen;
                currentScreen.LoadContent(content);
            }
            else if (fade.Alpha == 0.0f)
            {
                transition = false;
                fade.IsActive = false;
            }
        }

        #endregion
    }
}