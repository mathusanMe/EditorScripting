using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.IMGUI.Controls;

[CustomEditor(typeof(ArcHandleDemo))]
public class ArcHandleDemoEditor : Editor
{
    ArcHandleDemo m_Target;
    ArcHandle m_ArcHandle;

    private void OnEnable()
    {
        m_ArcHandle = new ArcHandle();
        m_ArcHandle.SetColorWithRadiusHandle(Color.red, 0.2f);
    }

    void OnSceneGUI()
    {
        m_Target = (ArcHandleDemo)target;

        Matrix4x4 handleMatrix = Matrix4x4.TRS(m_Target.transform.position, m_Target.transform.rotation, Vector3.one);

        m_ArcHandle.angle = m_Target.Angle;
        m_ArcHandle.radius = m_Target.Radius;

        Handles.color = Color.white;
        using(new Handles.DrawingScope(handleMatrix))
        {
            m_ArcHandle.DrawHandle();
        }

        m_Target.Angle = m_ArcHandle.angle;
        m_Target.Radius = m_ArcHandle.radius;
    }
}
