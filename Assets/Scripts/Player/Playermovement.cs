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

    private Touch movementTouchInput;
    private Vector2 touchStartPos, touchEndPos;
    [SerializeField] float currentSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float Acceleration;
    [SerializeField] float jumpForce;
    [SerializeField] float time;



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

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
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

    //void Jump()
    //{

    //}
    //void Slide()
    //{

    //}
    void Acclerate(float addedspeed)
    {
        currentSpeed += addedspeed;
        
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
