using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MV
{
    public class Background : ImageBase
    {
        public Background(int width, int height,
            Color32 color, int x = 0, int y = 0)
            :
            base(width, height, color, x, y)
        {

        }

        public override void Draw()
        {
            base.Draw();
        }
    }

}
