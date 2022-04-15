using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartController : MonoBehaviour
{
    //Jump Vars
    [SerializeField]
    AnimationCurve jump;
    bool grounded = true, jumping = false;
    float jumpTimer = 0, jumpPos = 0;


    private Rigidbody rb;
    // adding a speed variable
    public float speed = 3.0f;
    // adding a brake variable
    public float BrakeSpeed = 1.0f;
    // adding a rotation position variable

    GameTimer gameManager = null;
    // Start is called before
    void Start()
    {
        // refering to the game object component/class
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.FindWithTag("Manager").GetComponent<GameTimer>();
    }


    // Update is called once per frame
    void Update()
    {
        //creating a jump command
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
        }
        if (jumping)
        {
            grounded = false;
            jumpTimer += Time.deltaTime;
            jumpPos = jump.Evaluate(jumpTimer);
            transform.position = new Vector3(transform.position.x, jumpPos, transform.position.z);
            if(jumpTimer > 1)
            {
                jumping = false;
                jumpTimer = 0;
                grounded = true;
            }
        }
        // adding movement for forward
        if (Input.GetKey(KeyCode.W))
        {
            //rb.velocity = new Vector3(0,  0, speed * 2);
            rb.velocity = transform.forward * speed * 2;
        }
        // adding movement for backward
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, 0, speed * -2);
        }

        // adding movement for rotation
        if (Input.GetButton("Horizontal"))
        {
            transform.Rotate(0.0f, Input.GetAxis("Horizontal"), 0.0f);
        }

        ////Adding Movement Button For Jump
       
    }

    //creating a function for when pavlova objexts are hit, Add 1 point 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Point")
        {
            Debug.Log("hit");
            Destroy(other.gameObject);
            gameManager.setPoints(1);
        }
    }
}

