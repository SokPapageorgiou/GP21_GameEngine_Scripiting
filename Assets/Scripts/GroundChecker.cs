using System;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool IsGorunded { get; private set; }
    [SerializeField] private float groundCheckLenght = 1f;
    [SerializeField] private float groundCheckRadius = 0.5f;
    [SerializeField] private LayerMask groundLayer;
    
    
    private void Update()
    {
        var ray = new Ray(transform.position, Vector3.down);
        IsGorunded = Physics.SphereCast(ray, groundCheckRadius,groundCheckLenght, groundLayer);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position + Vector3.down * groundCheckLenght, groundCheckRadius);
    }
}
