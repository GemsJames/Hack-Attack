﻿using System;
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
            newScreen = screen;
            screenStack.Push(screen);
            currentScreen.UnloadContent();
            currentScreen = newScreen;
            currentScreen.LoadContent(content);
        }

        public void Initialize()
        {
            currentScreen = new SplashScreen();
        }
        public void LoadContent(ContentManager Content)
        {
            content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent(Content);
        }
        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }

        #endregion
    }
}