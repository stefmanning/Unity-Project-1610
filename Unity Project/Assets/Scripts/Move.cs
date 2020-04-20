using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float turnspeed;
    public float verticalInput;
    public float horizontalInput;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward*speed*Time.deltaTime*verticalInput);
        transform.Rotate(Vector3.up * turnspeed * Time.deltaTime * horizontalInput);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }                   

 /*   // Detect collision with another object
    void OnCollisionEnter(Collision other){

        if (other.gameObject.CompareTag("Floor")) // Primary
        {
            Debug.Log("Colliding with Floor");
        }
        else if (other.gameObject.CompareTag("Obstacle")) // Secondary
        {
            Debug.Log("Colliding with an Obstacle");
        }
        else  // Default
        {
            Debug.Log("...");
        }
    }
    */

    void OnTriggerEnter(Collider other){
        Debug.Log("Triggered! >:(");
    }

}