using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MV
{
    public class ViewManager
    {
        ImageBase bg;
        public void InitAll()
        {
            LogicImage li = new LogicImage(ScreenSetting.width,
                                            ScreenSetting.height,
                                            ScreenSetting.BGColor);
            bg = new ImageBase(li);
        }
        
        public void DrawAll()
        {
            bg.Draw();
        }
    }

}

