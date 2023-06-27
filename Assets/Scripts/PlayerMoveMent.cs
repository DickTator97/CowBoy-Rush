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
    [SerializeField] float MoveMentDirection;
    [SerializeField] float Speed;
    [SerializeField] float MaxSpeed;
    [SerializeField] float Acceleration;
    [SerializeField] float JumpForce;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ObjectToMove.GetComponent<Rigidbody>().AddForce(Vector3.forward);
        // ObjectToMove.transform.position = MoveMentDirection;
    }

    void MovePlayer()
    {
        //1 Forward Movement
        //rb.AddForce(transform.forward * (Speed*(Time.deltaTime)));
    
    }
    private void Update()
    {
       // MovePlayer();
    }
    void FixedUpdate()
    {
        
    }


}
