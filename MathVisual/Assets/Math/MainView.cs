using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MV
{
    public class MainView : EditorWindow
    {
        static MainView window;
        static Rect windowRect;
        static ViewManager mgr;
        static Texture2D texture;

        [MenuItem("MathVisual/Show")]
        static void Init()
        {
            if (EditorApplication.isPlaying)
            {
                Debug.LogError("cannot be launched in Play mode.");
                return;
            }
            DestroyWindow();

            window = CreateInstance<MainView>();
            windowRect = new Rect((float)ScreenSetting.x, (float)ScreenSetting.y,
                                    (float)ScreenSetting.width, (float)ScreenSetting.height);
            window.position = windowRect;
            window.Show();

            mgr = new ViewManager();
            mgr.InitAll();

        }
        private void Update()
        {
            this.Repaint();


        }
        Color oldGUIColor;
        private void OnGUI()
        {
            mgr.DrawAll();
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
        private static void DestroyWindow()
        {
            if (window != null)
            {
                window.Close();
                DestroyImmediate(window);
                window = null;
            }

        }
    }
}
