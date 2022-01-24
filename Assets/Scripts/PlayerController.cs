using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    public float moveSpeed = 5f;
    public float jumpforce = 500f;

    private void Update()
    {
        var moveInput = Input.GetAxis("Horizontal");
        myRigidBody.velocity = new Vector3(moveInput * moveSpeed, myRigidBody.velocity.y, 0);

        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        if(jumpInput && myRigidBody.velocity.y == 0) myRigidBody.AddForce(Vector3.up * jumpforce);
    }
}
