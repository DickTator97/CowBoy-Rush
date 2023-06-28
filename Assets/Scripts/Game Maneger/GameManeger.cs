using UnityEngine;

public class GameManeger : MonoBehaviour
{
    #region UI 
    #region Main Menu
    public void OnMouseDown()
    {
        Debug.Log("Clicked");

    }
    #endregion
    #endregion

   [SerializeField] GameObject CemeraFollowObject;
   [SerializeField] float cameraOffset;
    private void Update()
    {
        
    }

}
