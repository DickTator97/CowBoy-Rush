using UnityEngine;
public class Player_Movement : MonoBehaviour
{
    //movement
    // Add A boolean condition to check if game started/Other Conditions Are Met(In Game Manager)
    //1. move player forward with add force
    //2. move player sideways with touch input
    //3. make player jump while dragging finger upwards
    //4. make player slide while dragging finger downwards
    //score
    //life 
    //animations (if existing)

    MapBoundary map_boundary;
    [SerializeField] float currentSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float Acceleration;
    [SerializeField] float jumpForce;
    [SerializeField] float time;
    [SerializeField] GameObject Player;
    private float difference;
    private float leftBoundary, rightBoundary;
    private Vector2 touchStartPos, touchEndPos;

    void Start()
    {
        leftBoundary = map_boundary.internal_left;
        rightBoundary = map_boundary.internal_right;
        Accelerate(Acceleration);

    }
    private void Update()
    {
        PlayerMovement();
        TouchInputControl();
    }

    #region fix
    //  void MovePlayer()
    //{

    //    //1 Forward Movement
    //    //Add later Calculations of acceleration and max speed
    //    //CheckForValidLogic();
    //    transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed, Space.World);
    //  //TouchInputControl();
    //    KeyBoardControl();

    //    //2. left right movement
    //    //3. jump
    //    //4. slide
    //}

    void PlayerMovement()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed, Space.World);
    }


    #region MouseInput

    void OnMouseDown()
    {

    }
    #endregion
    #region TouchInput
    void TouchInputControl()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchStartPos = Input.GetTouch(0).position;
        }

        //return later for improvement
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
        #endregion
        //  Debug.Log("Touch Input is active:");
    }


    #region SideWays Movement
    Vector3 LeftMove()
    {
        //wip
        Accelerate(Acceleration);
        if (this.gameObject.transform.position.x > map_boundary.transform.position.x)
        {

            transform.Translate(Vector3.left * Time.deltaTime * (currentSpeed/*+Acceleration*/), Space.World);

        }
        return gameObject.transform.position;
    }
    Vector3 RightMove()
    {
        //wip
        Accelerate(Acceleration);

        if (this.gameObject.transform.position.x < map_boundary.transform.position.x)
        {

            transform.Translate(Vector3.right * Time.deltaTime * (currentSpeed /*+ Acceleration*/), Space.World);
        }
        return gameObject.transform.position;
    }
    #endregion
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

        float diff = difference;
        diff = (currentSpeed + addedSpeed) - maxSpeed;
        if (diff < 0)
        {
            diff = 0;
        }
        // add checks for conditions for acceleration
        //1.current speed +added speed Cannot be higher than max speed
        //2.cannot accelerate past max speed
        //3. add a difference variable, if the calculations add additional speed 
        //subtract the difference 

        if (currentSpeed < maxSpeed || currentSpeed + addedSpeed < maxSpeed)

        {

            currentSpeed += addedSpeed;

            if (currentSpeed + addedSpeed > maxSpeed)
            {
                maxSpeed -= diff;
            }
        }

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
}