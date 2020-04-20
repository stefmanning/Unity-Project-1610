using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Delaration
    public int cookieBox;
    public float waterBottle;
    private string firstName;
    public double rbi;
    public GameObject player;

    public float amount;
    public float money;
    public float cost;



    // Start is called before the first frame update
    void Start()
    {
        Cookies(amount, money, cost);



        cookieBox = 20;
        firstName = "Blob";
        Debug.Log("How many cookies did I steal from the jar " + cookieBox);
        //Function Call
        CheckScore();
    }

    // Update is called once per frame
    void Update()
    {
 
    }


    void Cookies(float amount, float money, float cost)
    {
        print("yo they sellin' biscuits");

        float total;
        total = money - cost * amount;
        print(total);
    }

    void CheckScore()
    {
        print("Hello there.");

    }



}
