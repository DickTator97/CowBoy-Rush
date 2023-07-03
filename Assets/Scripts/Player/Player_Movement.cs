using UnityEngine;
public class Player_Movement : MonoBehaviour
{

    //1. make player jump while dragging finger upwards
    //2. make player slide while dragging finger downwards
    //score
    //life 
    //animations (if existing)
    Map_Boundary map_boundary;
    [SerializeField] float currentSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float Acceleration;
    [SerializeField] float jumpForce;
    [SerializeField] float time;
    public Transform Player;
    private Vector2 touchStartPos, touchEndPos;



    void Start()
    {
        Accelerate(Acceleration);
    }
    private void Update()
    {
    
        PlayerMovement();
      

    }
    #region Movement
   
  
   
    void PlayerMovement()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * (currentSpeed + Acceleration), Space.World);
        LeftRightSwipe();
    }
    #region TouchInput
    #endregion
   void LeftRightSwipe()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchStartPos = Input.GetTouch(0).position;

        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchEndPos = Input.GetTouch(0).position;



            if (touchEndPos.x < touchStartPos.x)
            {
                LeftMove();
            }
            if (touchEndPos.x > touchStartPos.x)
            {
                RightMove();
            }

        }
    }
    void RightMove()
    {
        if (Player.transform.position.x < map_boundary.internal_right)
        {
            transform.Translate(Vector3.right * Time.deltaTime * (currentSpeed + Acceleration), Space.World);

        }
    }
    void LeftMove()
    {
        if (Player.transform.position.x > map_boundary.internal_left)
        {
            transform.Translate(Vector3.left * Time.deltaTime * (currentSpeed + Acceleration), Space.World);

        }
    }
    //3. jump
    //4. slide
    //}
   



#endregion
    //void Jump()
    //{

    //}
    //void Slide()
    //{

    //}
    #region Acceleration
    void Accelerate(float addedSpeed)
    {
        currentSpeed += addedSpeed;
        if (currentSpeed < 0)
        {
            currentSpeed = 0;
        }
        if (currentSpeed >= maxSpeed)
        {
            maxSpeed = currentSpeed;
        }
        if (maxSpeed < 1)
        {
            maxSpeed = 1;
        }
        if (jumpForce < 0)
        {
            jumpForce = 0;
        }
    }
    #endregion

    void KeyBoardMovement()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed, Space.World);
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > map_boundary.internal_left)
            {

                transform.Translate(Vector3.left * Time.deltaTime * currentSpeed, Space.World);
            }


        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < map_boundary.internal_right)
            {

                transform.Translate(Vector3.right * Time.deltaTime * currentSpeed, Space.World);
            }

        }
    }


}
