using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObstacle : MonoBehaviour
{
    private Rigidbody rb;
    public float torque;
    public float spinSpeed;

    private float zSpeed;
    public float thrust = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //zSpeed = Input.GetAxis("Vertical") * spinSpeed;
        rb.transform.Rotate(new Vector3(0, 0, spinSpeed));
        //rb.AddForce(Vector3.up * 200f);
        //rb.AddForce.Rotate(new Vector3(0, 0, spinSpeed));
        //rb.AddForce(transform.forward * thrust);
        //rb.AddForce(0, 0, thrust, ForceMode.Impulse);


        //Quaternion newRotation = Quaternion.RotateTowards(rb.rotation, Quaternion.Euler(new Vector3(0, 0, spinSpeed)));
        //rb.MoveRotation(newRotation);
    }
}
