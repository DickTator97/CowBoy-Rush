using UnityEngine;

public class GameManager : MonoBehaviour
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
    
    [SerializeField] GameObject CemeraFollowObject;
    [SerializeField] float cameraOffset;
    #endregion
    private void Update()
    {

    }

}
