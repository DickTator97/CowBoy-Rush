using UnityEngine;

public class GameManeger : MonoBehaviour
{
    #region UI 
    #region Main Menu
    
    public void OnMouseDown()
    {
        //1. load scene
        //2.enable\disable UI Elements
        Debug.Log("Clicked");

    }
    #endregion
    #endregion

    #region Camera Follow
    
    [SerializeField] GameObject Camera;
    [SerializeField] Transform Target;
    [SerializeField] Vector3 cameraOffset=new Vector3(0,0,0);
    [SerializeField] float smoothTime;
    private float AxisX, AxisY, AxisZ;
    private float cameraCurrentPos;
    #endregion
    
    private void LateUpdate()
    {
        //CameraFollow();
    }

    //void CameraFollow()
    //{
    //    transform.position = Vector3.SmoothDamp
    //        (
    //         //transform.position,Target.position+cameraOffset 
    //        // ref Player_Movement.
    //        );
      
    //}
}
