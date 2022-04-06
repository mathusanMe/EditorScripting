using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PositionHandleDemo))]
public class PositionHandleDemoEditor : Editor
{
    PositionHandleDemo m_Target;

    void OnSceneGUI()
    {
        m_Target = (PositionHandleDemo)target;

        for(int i = 0; i < m_Target.transform.childCount; ++i)
        {
            Transform child = m_Target.transform.GetChild(i);

            child.position = Handles.PositionHandle(child.position, child.rotation);
        }
    }
}
