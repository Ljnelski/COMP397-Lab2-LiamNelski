using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementForce;
    [SerializeField] private float jumpForce;
    
    private bool isGrounded;
    private Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetAxis("Horizontal") > 0.1f)
            {
                rbody.AddForce(Vector3.right * movementForce);
            }
            else if (Input.GetAxis("Horizontal") < -0.1f)
            {
                rbody.AddForce(Vector3.left * movementForce);
            }

            if (Input.GetAxis("Vertical") > 0.1f)
            {
                rbody.AddForce(Vector3.forward * movementForce);
            }
            else if (Input.GetAxis("Vertical") < -0.1f)
            {
                rbody.AddForce(Vector3.back * movementForce);
            }
            if (Input.GetAxis("Jump") > 0.1f)
            {
                rbody.AddForce(Vector3.up * jumpForce);
            }
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
