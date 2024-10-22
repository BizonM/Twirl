using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody2D playerRigidBody2D;

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
            PlayerMove("up");
        
        if (Input.GetKey("s"))
            PlayerMove("down");
        
        if (Input.GetKey("a"))
            PlayerMove("left");
        
        if (Input.GetKey("d"))
            PlayerMove("right");
    }
    void PlayerMove(string direction)
    {
        switch (direction)
        {
            case "up":
                playerRigidBody2D.AddForce(transform.up * moveSpeed, ForceMode2D.Force);
                break;
            case "down":
                playerRigidBody2D.AddForce(transform.up * -moveSpeed, ForceMode2D.Force);
                break;
            case "left":
                playerRigidBody2D.AddForce(transform.right * -moveSpeed, ForceMode2D.Force);
                break;
            case "right":
                playerRigidBody2D.AddForce(transform.right * moveSpeed, ForceMode2D.Force);
                break;
        }
    }
}

