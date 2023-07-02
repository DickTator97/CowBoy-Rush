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
    [SerializeField] GameObject Target;
    [SerializeField] float cameraOffset;
    private float cameraCurrentPos;
    #endregion
    private void Update()
    {
        CameraFollow();
    }

    void CameraFollow()
    {
        
        cameraCurrentPos=Camera.transform.position.z+Target.transform.position.z-cameraOffset;

        if (cameraCurrentPos<5)
        {
            cameraCurrentPos = 5;
        }
    }
}
