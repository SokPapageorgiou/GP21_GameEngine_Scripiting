using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private PlayerInputController inputController;
    
    private void Update()
    {
        var moveInput = inputController.MoveInput;
        myRigidBody.velocity = new Vector3(moveInput * moveSpeed, myRigidBody.velocity.y, 0);
    }
}
