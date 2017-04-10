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

        // Guarda os GameScreens

        Dictionary<string, GameScreen> screens = new Dictionary<string, GameScreen>();

        //Screen Stack

        Stack<GameScreen> screenStack = new Stack<GameScreen>();

        //Tamanho do Ecrã

        Vector2 dimensions;
        #endregion
    }
}
