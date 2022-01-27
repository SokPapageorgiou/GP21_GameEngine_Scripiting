using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    public float moveSpeed = 5f;
    
    private void Update()
    {
        var moveInput = Input.GetAxis("Horizontal");
        myRigidBody.velocity = new Vector3(moveInput * moveSpeed, myRigidBody.velocity.y, 0);
    }
}
