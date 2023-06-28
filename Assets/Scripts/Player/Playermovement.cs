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

    //Vector3 movementDirection;
    //Rigidbody rb;
    //[SerializeField] GameObject objectToMove;

    object swipetarget;
    private Touch movementinput;
    [SerializeField] float currentSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float Acceleration;
    [SerializeField] float jumpForce;
    [SerializeField] float time;

    // Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    objectToMove.transform.position = movementDirection;

    //}

    void Start()
    {

        CheckForValidLogic();

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
        //add touch input for both with began and ended
        //2. left right movment


        if (movementinput.phase == TouchPhase.Began)
        {
         //?
        }
        if (movementinput.phase == TouchPhase.Moved)
        {
            // check if input recived is postivie or negative 
            // and move player accordingly
        }
        if (movementinput.phase==TouchPhase.Ended)
        {
            //Move Player Towards Position
        }

        //3. jump
    }


    void CheckForValidLogic()
    {


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
