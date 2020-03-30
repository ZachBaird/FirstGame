using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Public RigidBody we built so we could assign the Player's RigidBody component to the script.
    public Rigidbody rigidBody;

    // Speed the player is propelled forward.
    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;

    // Start is called before the first frame update.
    void Start() => Debug.Log("PlayerMovement script started.");
    

    // FixedUpdate is called once per frame. Unity prefers that we used FixedUpdate vs. Update
    //  when it comes to physics.
    void FixedUpdate()
    {
        // This line of code will launch our sphere into the ether. We multiple our force by 
        //  Time.deltaTime because Update & FixedUpdate run per frame. This means there will be
        //  unequal evaluations per system because each computer runs frames at different speeds.
        // Using Time.deltaTime equalizes the difference between frames running at different speeds.
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Check for any of the following keys being pressed. Push player left or right per result.
        if (Input.GetKey(KeyCode.A))
            rigidBody.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        else if (Input.GetKey(KeyCode.D))
            rigidBody.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        
    }
}
