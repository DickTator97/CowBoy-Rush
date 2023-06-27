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

    Vector3 movementDirection;
    Rigidbody rb;
    [SerializeField] GameObject objectToMove;
    //current speed*
    [SerializeField] float currentSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float Acceleration;
    [SerializeField] float jumpForce;


    // Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    objectToMove.transform.position = movementDirection;

    //}

    void start()
    {
   

      
       
    
  
    }
    private void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        if (currentSpeed < 0)
        {
            currentSpeed = 0;
        }

        if (currentSpeed > maxSpeed)
        {
            currentSpeed = maxSpeed;
        }
        if (maxSpeed < 0)
        {
            maxSpeed = 0;
        }

        if (jumpForce < 0)
        {
            jumpForce = 0;
        }
        Debug.Log($"current Speed:{currentSpeed}");
        Debug.Log($"max Speed:{maxSpeed}");
        Debug.Log($"jump force:{jumpForce}");
        //1 Forward Movement
        //Add later Calculations of acceleration and maxspeed
        transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed, Space.World);
        //add touch input for both with began and ended
        //2. left right movment
        //3. jump
    }



}
