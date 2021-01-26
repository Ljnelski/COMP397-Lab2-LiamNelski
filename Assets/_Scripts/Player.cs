using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementForce;

    private Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
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
    }
}
