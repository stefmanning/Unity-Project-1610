using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObject : MonoBehaviour
{

    public string objectName;

    public string description;

    public GameObject model;

    public Color color;

    private void PrintOut(string name, string description)
    {
        Debug.Log(name + " " + description);
        if (name == "Captain America")
        {
            Debug.Log("Captain America allows this program to run!");
        }
    }
}