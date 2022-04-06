using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LinesDemo))]
public class LinesDemoEditor : Editor
{
    LinesDemo m_Target;

    void OnSceneGUI()
    {
        m_Target = (LinesDemo)target;

        Handles.color = Color.yellow;

        for(int i = 1; i < m_Target.transform.childCount + 1; ++i)
        {
            Transform lastChild = m_Target.transform.GetChild(i - 1);
            Transform currentChild = m_Target.transform.GetChild(i % m_Target.transform.childCount);

            Handles.DrawDottedLine(lastChild.position, currentChild.position, 4f);
        }

        Vector3[] polygonPoints = new Vector3[m_Target.transform.childCount];
        for(int i = 0; i < m_Target.transform.childCount; ++i)
        {
            polygonPoints[i] = m_Target.transform.GetChild(i).position;
        }

        Handles.color = Color.yellow * new Color(1f, 1f, 1f, 0.2f);
        Handles.DrawAAConvexPolygon(polygonPoints);
    }
}
