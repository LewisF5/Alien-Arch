using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //Reference variable so we can use the rigidbody
    //set it to null default, which means we do not have a reference yet
    private Rigidbody2D physicsBody = null;

    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    public Collider2D groundSensor = null;
    public LayerMask groundlayer = 0;

    public float speed = 1;
    public void MoveLeft()
    {
        //Make a variable to hold our velocity and get the
        //current velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;
        //Set our velocity to move in the negative x (left) direction
        newVelocity.x = -speed;
        //Update our physics components velocity to be our newly changed value
        physicsBody.velocity = newVelocity;
    }
    public void MoveRight()
    {
        //Make a variable to hold our velocity and get the
        //current velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;
        //Set our velocity to move in the negative x (left) direction
        newVelocity.x = speed;
        //Update our physics components velocity to be our newly changed value
        physicsBody.velocity = newVelocity;
    }

    public void Jump()
    {
        if (groundSensor.IsTouchingLayers(groundlayer))
        {
            Vector2 newVelocity = physicsBody.velocity;
            newVelocity.y = jumpspeed;
            physicsBody.velocity = newVelocity;
        }
    }
    public float jumpspeed = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
