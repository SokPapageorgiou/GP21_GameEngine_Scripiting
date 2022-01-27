using UnityEngine;

public class PlayerImediateJump : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    [SerializeField] private float jumpforce = 500f;
    [SerializeField] private PlayerInputController inputController;
    [SerializeField] private GroundChecker groundChecker;
    
    private void Update()
    {
        var jumpInput = inputController.JumpInput;
        if(jumpInput && groundChecker.IsGorunded) myRigidBody.AddForce(Vector3.up * jumpforce);
    }
}
