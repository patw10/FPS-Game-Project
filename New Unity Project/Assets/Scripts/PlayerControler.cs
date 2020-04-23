using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public CharacterController charControl;
    private float xDir;
    private float yDir;
    private float zDir;
    private Vector3 moveDirection;

    public float speed = 10f;
    public float jump = 1f;
    public float ground = 0.2f;
    public LayerMask groundLayer;
    public Transform grandCheck;
    private bool isGrounded;

    void Start()
    {
        
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(grandCheck.position, ground, groundLayer);
        if(isGrounded && yDir < 0)
        {
            yDir = -2f;
        }

        xDir = Input.GetAxis("Horizontal");
        zDir = Input.GetAxis("Vertical");

        yDir += Physics.gravity.y * Time.deltaTime;

        moveDirection = transform.right * xDir * speed + transform.forward * zDir * speed + transform.up * yDir;
        charControl.Move(moveDirection * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            yDir = Mathf.Sqrt(jump * -2f * Physics.gravity.y);
        }
    }
}
