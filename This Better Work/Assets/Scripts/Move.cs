using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public static int speed = 10;
    public float turnSpeed;
    public float verticalTurnSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float updownInput;
    public float RotateSpeed = 30f;

    public static int ammoTotal;

    public bool isGrounded;
    public float jumpHeight;
    private Rigidbody rb;

    public static int health;
   
    public float cooldown;
    public float rof;


    void Start()
    {
     
        health = PlayerHealth.maxHealth;
        
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        //Inputs
       verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Mouse Y");
        updownInput = Input.GetAxis("Mouse X");

        // transformations
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);//Equal 2 (0, 0, .1f)
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
   

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpHeight * 100 * Time.deltaTime * 100);

        }

        {
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
            else if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
        }


        if (health <= 0)
        {

            //speed = 0;
            speed = 0;
            turnSpeed = 0;
            print("Game Over");
            jumpHeight = 0;

        }

        if (health >= PlayerHealth.maxHealth)
        {
            health = PlayerHealth.maxHealth;

        }

    }

  


    public static void boostOn()
    {
        speed = speed * 2;
        print("boost on");
       
    }




     public static void boostOff()
    {
        speed = speed / 2;
        print("boost off");
    }
    
    
    public static void AddHealth(int healthAmt)
    {
        health = health + healthAmt;
        print("Current HP " + health);

    }



    /* void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Obstacle"))
        {
            isGrounded = true;

        }

        else
        {

        }

    }*/

    //void OnCollisionExit(Collision other);
    /*{
        if (other.gameObject.CompareTag("Enemy"))
        {

        }

        else if (other.gameObject.CompareTag("Ranged Enemy"))
        {

        }

        else
        {
            isGrounded = false;


        }

    }*/
}