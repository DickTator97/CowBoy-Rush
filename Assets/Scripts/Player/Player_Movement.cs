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
    private Vector2 touchStartPos, touchEndPos;

    // private float swipeThreshold = 50f; // Adjust this value to set the minimum swipe distance

    //public float Left_Limit;
    //public float right_Limit;

    void Start()
    {
        Accelerate(Acceleration);
        //Mapboundary mb = gameObject.GetComponent<Mapboundary>();


    }
    private void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {

        //1 Forward Movement
        //Add later Calculations of acceleration and max speed
        //CheckForValidLogic();
        transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed, Space.World);
        TouchInputControl();
        //2. left right movement
        //3. jump
        //4. slide
    }

    void TouchInputControl()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchStartPos = Input.GetTouch(0).position;
        }

        //return later for improvement

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchEndPos = Input.GetTouch(0).position;
            if (touchEndPos.x < touchStartPos.x)
            {
                if (this.gameObject.transform.position.x > map_boundary.internal_left)
                {
                    LeftMove();

                }

            }

            if (touchEndPos.x > touchStartPos.x)
            {
                if (this.gameObject.transform.position.x < map_boundary.internal_right)
                {
                    RightMove();

                }

            }
        }


    }
    void LeftMove()
    {
        //wip
        Accelerate(Acceleration);


        transform.Translate(Vector3.left * Time.deltaTime * (currentSpeed/*+Acceleration*/), Space.World);

    }
    void RightMove()
    {
        //wip
        Accelerate(Acceleration);


        transform.Translate(Vector3.right * Time.deltaTime * (currentSpeed /*+ Acceleration*/), Space.World);


    }

    //void Jump()
    //{

    //}
    //void Slide()
    //{

    //}
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
}