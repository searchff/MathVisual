using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace Fight
{
    public class FightTest : EditorWindow
    {
        static Color gridLineColor = new Color32(88, 88, 88, 255);
        static Color oldGUIColor;
        static Texture2D texture;
        private static FightTest window = null;
        static Rect rect;
        //编译完的回调
        //[UnityEditor.Callbacks.DidReloadScripts]
        private static void OnScriptsReloaded()
        {
            if (EditorApplication.isPlaying)
            {
                Debug.LogError("cannot be launched in Play mode.");
                return;
            }

            DestroyWindow();

            window = CreateInstance<FightTest>();
            //创建窗口
            rect = new Rect(200, 200, 800, 800);
            //window = (FightTest)EditorWindow.GetWindow(typeof(FightTest));
            //window.titleContent = "draw test";

            //window.minSize = new Vector2(800, 800);
            //window.maxSize = new Vector2(800, 800);
            window.position = rect;
            


            texture = new Texture2D(1, 1);
            texture.SetPixel(0, 0, Color.white);
            texture.Apply();
            texture.hideFlags = HideFlags.DontSave;

            window.Show();

            //window.ShowPopup();


            //window.ShowUtility();

        }

        void InitRes()
        {

        }

        [ContextMenu("SetData")]
        private void SetData()
        {

        }
        [MenuItem("Math/ShowWindow")]
        private static void Init()//菜单打开时调用
        {
            OnScriptsReloaded();
        }

        private void Update()
        {
            //this.Repaint();
            
           
        }
       
        private static void DestroyWindow()
        {
            if (window != null)
            {
                window.Close();
                DestroyImmediate(window);
                window = null;
            }
        }
        private void OnGUI()
        {
            DrawTexture(rect, texture, gridLineColor);

            Event e = Event.current;
            if (e != null)
            {
                if (e.isKey)
                {
                    if (e.keyCode == KeyCode.Escape)
                    {
                        DestroyWindow();
                    }
                }
            }
        }

        static void DrawTexture(Rect rect, Texture2D texture, Color color)
        {
            Rect re = new Rect(0, 0, 800, 800);
            oldGUIColor = GUI.color;
            GUI.color = color;
            GUI.DrawTexture(re, texture);
            GUI.color = oldGUIColor;
        }

    }
}
