using UnityEngine;

public class Playermovement : MonoBehaviour
{
    //movment
    // Add A boolean condition to check if game started/Other Conditions Are Met(In Game Manager)

    //1. move player forward with add force
    //2. move player sideways with touch input
    //3. make player jump while dragging finger upwards
    //4. make player slide while dragging finger downwards


    //score
    //life 
<<<<<<< Updated upstream:Assets/Scripts/Player/Playermovement.cs
    //animations (if exisiting)

  
    [SerializeField] GameObject ScreenDirInput;

    private Touch movementTouchInput;
    private Vector2 touchStartPos, touchEndPos;
=======
    //animations (if existing)
    Map_Boundary map_boundary;
>>>>>>> Stashed changes:Assets/Scripts/Player/Player_Movement.cs
    [SerializeField] float currentSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float Acceleration;
    [SerializeField] float jumpForce;
    [SerializeField] float time;
<<<<<<< Updated upstream:Assets/Scripts/Player/Playermovement.cs



    void Start()
    {
        Acclerate(Acceleration);

    }
    private void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {

        //1 Forward Movement
        //Add later Calculations of acceleration and maxspeed
        //CheckForValidLogic();
        transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed, Space.World);
        TouchInputControll();
        //2. left right movment

        //3. jump
        //4. slide
    }

    void TouchInputControll()
    {
=======
    private Vector2 touchStartPos, touchEndPos;
   // private float leftMoveLimit, rightMoveLimit;
    void Start()
    {
        Accelerate(Acceleration);
    }
    private void Update()
    {
        //leftMoveLimit = map_boundary.internal_left;
       // rightMoveLimit = map_boundary.internal_right;
        PlayerMovement();

    }
    #region fix
    //  void MovePlayer()
    //{
    //1 Forward Movement
    //Add later Calculations of acceleration and max speed
    //transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed, Space.World);
    //TouchInputControl();
    // KeyBoardControl();
    //2. left right movement
    //3. jump
    //4. slide
    //}

    void PlayerMovement()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * (currentSpeed /*+ Acceleration*/), Space.World);
        TouchInputControl();
    }
  
    #region TouchInput
    void TouchInputControl()
    {
        
>>>>>>> Stashed changes:Assets/Scripts/Player/Player_Movement.cs
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchStartPos = Input.GetTouch(0).position;
          
        }
<<<<<<< Updated upstream:Assets/Scripts/Player/Playermovement.cs

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
=======
        //return later for improvement
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
>>>>>>> Stashed changes:Assets/Scripts/Player/Player_Movement.cs
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
<<<<<<< Updated upstream:Assets/Scripts/Player/Playermovement.cs
    }
    void LeftMove()
    {
      
        Acclerate(Acceleration);
        transform.Translate(Vector3.left * Time.deltaTime * (currentSpeed+Acceleration), Space.World);
    }
    void RightMove()
    {
        Acclerate(Acceleration);
        transform.Translate(Vector3.right * Time.deltaTime *( currentSpeed+Acceleration), Space.World);

    }

=======
        #endregion
        //Debug.Log("Touch Input is active:");
    }
    #region SideWays Movement
    void LeftMove()
    {
        //wip
        Accelerate(Acceleration);
        if (this.gameObject.transform.position.x > map_boundary.internal_left)
        {
            transform.Translate(Vector3.left * Time.deltaTime * (currentSpeed/*+Acceleration*/), Space.World);
        }
    }
    void RightMove()
    {
        //wip
        Accelerate(Acceleration);
        if (this.gameObject.transform.position.x < map_boundary.internal_right)
        {
            transform.Translate(Vector3.right * Time.deltaTime * (currentSpeed /*+ Acceleration*/), Space.World);
        }
    }
    #endregion
    #endregion
>>>>>>> Stashed changes:Assets/Scripts/Player/Player_Movement.cs
    //void Jump()
    //{

    //}
    //void Slide()
    //{

    //}
    void Acclerate(float addedspeed)
    {
<<<<<<< Updated upstream:Assets/Scripts/Player/Playermovement.cs
        currentSpeed += addedspeed;
        
=======
        currentSpeed += addedSpeed;
>>>>>>> Stashed changes:Assets/Scripts/Player/Player_Movement.cs
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

        //Debug.Log($"current Speed:{currentSpeed}");
        //Debug.Log($"max Speed:{maxSpeed}");
        //Debug.Log($"jump force:{jumpForce}");
    }

}
