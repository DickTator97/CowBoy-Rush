using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset = new Vector3(0, 2, -10);

    private void LateUpdate()
    {
        transform.position = Target.position + Offset;
    }
}
