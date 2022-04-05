using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GUIDemo))]
public class GUIDemoEditor : Editor
{
    GUIDemo m_Target;

    void OnSceneGUI()
    {
        m_Target = (GUIDemo)target;

        Handles.BeginGUI();
        {
            GUIStyle boxStyle = new GUIStyle("box");

            GUILayout.BeginArea(new Rect(10, 10, 200, 70), boxStyle);
            {
                GUILayout.Label("GUI Label Demo");
                m_Target.TestValue = GUILayout.HorizontalSlider(m_Target.TestValue, 0, 10);
                
                GUILayout.Space(20);

                if(GUILayout.Button("Hello World"))
                {
                    Debug.Log("Hello World!");
                }
            }
            GUILayout.EndArea();
        }
        Handles.EndGUI();
    }
}
