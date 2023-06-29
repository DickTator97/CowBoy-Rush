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
    //animations (if exisiting)


    [SerializeField] GameObject ScreenDirInput;
    [SerializeField] float currentSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float Acceleration = 0;
    [SerializeField] float jumpForce;
    [SerializeField] float time;

    private Touch movementTouchInput;
    private Vector2 touchStartPos, touchEndPos;
    private float swipeThreshold = 50f; // Adjust this value to set the minimum swipe distance
    public float Left_Limit;
    public float right_Limit;

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
        
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchStartPos = Input.GetTouch(0).position;
        }

        //return later for improvement
        touchEndPos = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved && Input.touchCount > 0)
        {
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
    void LeftMove()
    {

        Acclerate(Acceleration);
       if (this.gameObject.transform.position.x>MapBoundry.internal_left;)
        {

        }
        transform.Translate(Vector3.left * Time.deltaTime * (currentSpeed/*+Acceleration*/), Space.World);
    }
    void RightMove()
    {
        Acclerate(Acceleration);
        transform.Translate(Vector3.right * Time.deltaTime * (currentSpeed /*+ Acceleration*/), Space.World);

    }

    //void Jump()
    //{


    //}
    //void Slide()
    //{

    //}
    void Acclerate(float addedSpeed)
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

}
