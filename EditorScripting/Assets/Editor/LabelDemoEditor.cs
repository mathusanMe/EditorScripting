using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LabelDemo))]
public class LabelDemoEditor : Editor
{
    LabelDemo m_Target;

    void OnSceneGUI()
    {
        m_Target = (LabelDemo)target;

        GUIStyle textStyle = new GUIStyle();
        textStyle.fontSize = 14;
        textStyle.normal.textColor = Color.white;
        textStyle.alignment = TextAnchor.MiddleCenter;

        Handles.Label(m_Target.transform.position + Vector3.down * 1.3f, m_Target.transform.position.ToString(), textStyle);
    }
}
