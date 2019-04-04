using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MV
{
    public class LogicImage
    {
        public int width = 0;
        public int height = 0;
        Color32[,] data;
        public LogicImage(int width, int height, Color32 color)
        {
            this.width = width;
            this.height = height;
            data = new Color32[width, height];
            for(int i=0; i<width; ++i)
            {
                for(int j=0; j<height; ++j)
                {
                    data[i, j] = color;
                }
            }

        }
        public void SetPixel(int x, int y, Color32 color)
        {
            data[x, y] = color;
        }
        public void FillBlock(Color32[] block)
        {
            if(block.Length != width*height)
            {
                Debug.LogError("array length wrong");
                return;
            }
            int index = 0;
            for(int i=0; i<height; ++i)
            {
                for(int j=0; j<width; ++j)
                {
                    block[index] = data[j,i];
                    ++index;
                }
            }
        }

    }

}
