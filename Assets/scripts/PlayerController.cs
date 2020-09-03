using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody rb;
    public float moveSpeed;

    private float xSpeed, zSpeed;

    public int score;
    public int gemValue = 1;
    void Start()
    {
        moveSpeed = 8f;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        xSpeed = Input.GetAxis("Horizontal") * moveSpeed;
        zSpeed = Input.GetAxis("Vertical") * moveSpeed;

        Vector3 movement = new Vector3(xSpeed, 0, zSpeed);

        rb.AddForce (movement);

        //rb.AddTorque(new Vector3(xSpeed, 0, zSpeed));
        //rb.velocity = new Vector3(x, rb.velocity.y, y);
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.CompareTag("Gem")){
            Destroy(Other.gameObject);
            ScoreManager.instance.ChangeScore(gemValue);
            score++;
        }
    }
}
