using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MV
{
    public class ImageBase
    {
        Texture2D texture = null;
        int width = 0;
        int height = 0;
        int x = 0;
        int y = 0;
        Color32 color;
        Color oldGUIColor;
        public ImageBase(int width, int height,
            Color32 color, int x = 0, int y = 0)
        {
            this.width = width;
            this.height = height;
            this.color = color;
            this.x = x;
            this.y = y;
            //texture = new Texture2D(width, height);
            //texture.SetPixel(x, y, color);
            //texture.Apply();
            //texture.hideFlags = HideFlags.DontSave;

        }
        public ImageBase(LogicImage logicImage)
        {
            this.width = logicImage.width;
            this.height= logicImage.height;
            texture = new Texture2D(width, height);
            Color32[] block = new Color32[width*height];
            logicImage.FillBlock(block);
            texture.SetPixels32(block);
            texture.Apply();
            texture.hideFlags = HideFlags.DontSave;

        }
        public virtual void Draw()
        {
            Rect re = new Rect(x, y, width, height);
            //oldGUIColor = GUI.color;
            //GUI.color = Color.black;
            GUI.DrawTexture(re, texture);
           // GUI.color = oldGUIColor;
        }

    }
    

}
