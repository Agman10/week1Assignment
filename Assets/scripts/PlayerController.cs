using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody rb;
    public float moveSpeed;

    private float xSpeed, zSpeed;

    
    public Text scoreText;
    public int score;
    public int gemValue = 1;

    public AudioSource gemSound;
    

    void Start()
    {
        moveSpeed = 8f;
        rb = GetComponent<Rigidbody>();

        score = 0;
        scoreText.text = "Gems: " + score.ToString();

        gemSound = GameObject.FindWithTag("GemSound").GetComponent<AudioSource>();
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
            gemSound.Play();
            Destroy(Other.gameObject);
            //ScoreManager.instance.ChangeScore(gemValue);
            score = score + 1;
            scoreText.text = "Gems: " + score.ToString();
        }
    }
}
