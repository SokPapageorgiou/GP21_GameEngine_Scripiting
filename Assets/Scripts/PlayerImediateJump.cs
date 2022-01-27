using UnityEngine;

public class PlayerImediateJump : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    [SerializeField] private float jumpforce = 500f;
    [SerializeField] private PlayerInputController inputController;
    
    private void Update()
    {
        var jumpInput = inputController.JumpInput;
        if(jumpInput && myRigidBody.velocity.y == 0) myRigidBody.AddForce(Vector3.up * jumpforce);
    }
}
