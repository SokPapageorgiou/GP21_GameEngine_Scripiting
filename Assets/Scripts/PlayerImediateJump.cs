using UnityEngine;

public class PlayerImediateJump : MonoBehaviour
{
    public Rigidbody myRigidBody;
    public float jumpforce = 500f;
    
    private void Update()
    {
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        if(jumpInput && myRigidBody.velocity.y == 0) myRigidBody.AddForce(Vector3.up * jumpforce);
    }
}
