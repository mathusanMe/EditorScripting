using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDemo : MonoBehaviour
{
    ButtonDemo(){}

    public void OpenDoor()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }

    public void CloseDoor()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;
    }
}
