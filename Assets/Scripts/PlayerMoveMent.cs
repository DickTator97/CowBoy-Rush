using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
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

    Rigidbody rb;
    [SerializeField]GameObject ObjectToMove;
    [SerializeField] float Movementdirection;
    [SerializeField] float Speed;
    [SerializeField] float MaxSpeed;
    [SerializeField] float Acceleration;
    [SerializeField] float JumpForce;
    public float thrust = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, thrust, ForceMode.Impulse);
    }

    void MovePlayer()
    {
        //1 Forward Movement
        rb.AddForce(transform.position *Speed *( Time.deltaTime));
       //Add later Calculations of acceleration and maxspeed
        rb.AddForce(0, 0, Speed, ForceMode.Impulse);
    }
    private void Update()
    {
        
    }
    void FixedUpdate()
    {
        
    }


}
