using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public Vector3 CameraOffset = new Vector3(0, 2, -10);
    public float SmoothTime = 0.50f;
    Vector3 currentVelocity;
   
    private void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(
            transform.position,
            Target.position + CameraOffset,
            ref currentVelocity,
            SmoothTime
            );
    }
}
