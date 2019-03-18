using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace Fight
{
    public class FightTest : EditorWindow
    {
        private static FightTest window;
        static GUISkin skin;
        static GUIStyle style;
        static GUIStyle style_on;
        
        ScaleBox sb;
        ScaleBox sb2;
        GridBG gbg;
        FrameContainer fc;
        FrameSprite fs;

        [MenuItem("fight/draw test")]
        private static void Init()//菜单打开时调用
        {
            if (EditorApplication.isPlaying)
            {
                Debug.LogError("cannot be launched in Play mode.");
                return;
            }
            //创建窗口
            Rect wr = new Rect(0, 0, 800, 600);
            window = (FightTest)EditorWindow.GetWindow(typeof(FightTest));
            window.title = "draw test";
            window.Show();
            //skin
            string path = "Assets/Res/myskin.guiskin";
            skin = (GUISkin)AssetDatabase.LoadAssetAtPath(path, typeof(GUISkin));
            style = skin.FindStyle("listbox");
            style_on = new GUIStyle(style);
            style_on.normal.background = style.onNormal.background;
            style_on.normal.textColor = style.onNormal.textColor;
            style_on.hover.background = style.onHover.background;
            style_on.hover.textColor = style.onHover.textColor;
            style_on.active.background = style.onActive.background;
            style_on.active.textColor = style.onActive.textColor;
            style_on.focused.background = style.onFocused.background;
            style_on.focused.textColor = style.onFocused.textColor;

            //asset 
            string strPath = "Assets/Res/FightData/verson.asset";

            //FrameData fd = ScriptableObject.CreateInstance<FrameData>();
            //FrameOne f = new FrameOne();
            //f.fName = "fram";
            //f.num = 100;
            //fd.fo = f;
            //AssetDatabase.CreateAsset(fd, strPath);
            //AssetDatabase.ImportAsset(strPath, ImportAssetOptions.ForceUpdate);

            //AssetDatabase.Refresh();
            //EditorUtility.SetDirty(fd);
            //AssetDatabase.SaveAssets();
            //
            //EditorUtility.SetDirty(data); // tell unity to save the editor data prefab changes to disk
            //AssetDatabase.SaveAssets(); // save assets now
            //AssetDatabase.Refresh();
            //return (T)AssetDatabase.LoadAssetAtPath(RelToAbsPath(relativePath), typeof(T));
            //File.Exists(RelToAbsPath(relativePath));

            //FrameData fd = (FrameData)AssetDatabase.LoadAssetAtPath(strPath, typeof(FrameData));
            //FrameOne f = fd.fo;
           // Debug.Log(f.fName);
            //Debug.Log(f.num);

            //Rect rect = new Rect(2, 3, 10, 20);
            //Debug.Log(rect.x);
            //Debug.Log(rect.y);
            //Debug.Log(rect.width);
            //Debug.Log(rect.height);
            //Debug.Log(rect.xMin);
            //Debug.Log(rect.yMin);
            //Debug.Log(rect.xMax);
            //Debug.Log(rect.yMax);
        }

        private void Update()
        {
            this.Repaint();
        }
        private float sliderValue = 1.0f;
        private float maxSliderValue = 10.0f;

        public Vector2 scrollPosition;
        public string longString = "This is a long-ish string";
        Rect rect;
        string path;
        ListBox lb;

        private void OnGUI()
        {
            if (fc == null)
            {
                fc = new FrameContainer(skin);
            }
            fc.Display();
        }
        void HandleControll()
        {
            Event e = Event.current;
            if (e.isMouse)
            {
                if (e.type == EventType.mouseDown)
                {
                    if (e.button == 0)
                    {
                        if (RotatableFillBox.RectContains(new Rect(100f, 100f, 200f, 100f), e.mousePosition, 20f))
                        {
                            Debug.Log("in box");
                        }
                        else
                            Debug.Log("out box");
                    }
                }
            }
        }
    }
}
