﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Hack_Attack
{
    class Enemy : Entity
    {
        public override void LoadContent(Microsoft.Xna.Framework.Content.ContentManager content, InputManager input)
        {
            base.LoadContent(content, input);
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime, InputManager input, Collision col, Layers layer)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}