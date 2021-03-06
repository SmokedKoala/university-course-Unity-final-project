using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionController : MonoBehaviour
{
    public CharacterController CharacterController;
    public float speed = 12f;
    public float gravity = -9.8f;
    Vector3 velocity;
    public Transform GroundCheck;
    public float GroundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded = true;
    public float jumpForce = 1000;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        CharacterController.Move(move * speed * Time.deltaTime);

        velocity.y += gravity + Time.deltaTime;
        CharacterController.Move((velocity * Time.deltaTime) / 2);

        isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
    }
}
