using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MV
{
    public class ViewManager
    {
        ImageBase bg;
        LineSegment line;
        public void InitAll()
        {
            LogicImage li = new LogicImage(ScreenSetting.width,
                                            ScreenSetting.height,
                                            ScreenSetting.BGColor);
            
            line = new LineSegment();
            line.Create(li, 10, 10, 100, 100, new Color32(0, 0, 255, 255));

            bg = new ImageBase(li);
        }
        
        public void DrawAll()
        {
            bg.Draw();
        }
    }

}

