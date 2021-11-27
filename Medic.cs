using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;
using cse210_batter_csharp.Scripting;

namespace cse210_batter_csharp
{
    /// <summary>
    /// 
    /// 
    /// Stereotype:
    ///     
    /// </summary>
    public class Medic : Actor 
    {
        public Medic()
        {
            // SetWidth(Constants.PADDLE_WIDTH);
            // SetHeight(Constants.PADDLE_HEIGHT);

            Point paddlePosition = new Point(Constants.MEDIC_X, Constants.MEDIC_Y);
            SetPosition(paddlePosition);
        }
    }
}
