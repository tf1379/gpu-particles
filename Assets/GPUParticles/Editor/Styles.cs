using UnityEngine;
using UnityEditor;

namespace GPUParticles
{
    public class Styles
    {
        public static GUIStyle moduleHeader;
        public static GUIStyle title;
        public static GUIStyle textRight;

        static Styles()
        {
            moduleHeader = new GUIStyle(GUI.skin.box);
            moduleHeader.padding = new RectOffset(32, 10, 3, 3);
            // moduleHeader.normal.textColor = EditorGUIUtility.isProSkin ? Color.black : Color.white;

            title = new GUIStyle(GUI.skin.label);
            title.alignment = TextAnchor.MiddleCenter;

            textRight = new GUIStyle(GUI.skin.label);
            textRight.alignment = TextAnchor.UpperRight;
        }
    }
}