using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ButtonDemo))]
public class ButtonDemoEditor : Editor
{
    ButtonDemo m_Target;

    void OnSceneGUI()
    {
        m_Target = (ButtonDemo)target;

        Handles.color = Color.green;
        if (Handles.Button(m_Target.transform.position + Vector3.down, Quaternion.identity, 1f, 1f, Handles.CubeHandleCap) == true)
        {
            m_Target.OpenDoor();
        }

        Handles.color = Color.red;
        if (Handles.Button(m_Target.transform.position + Vector3.down + Vector3.left * 2, Quaternion.identity, 1f, 1f, Handles.SphereHandleCap) == true)
        {
            m_Target.CloseDoor();
        }
    }
}
