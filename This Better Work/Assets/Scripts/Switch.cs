﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called before the first frame update

    //://learn.unity.com/tutorial/switch-statements#5c8a6f91edbc2a067d4753d4

    /// practice with switch

    public int Random = 4;

        void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))

            switch (Random)
            {
                case 1:
                    print("Switch ");
                    break;

                case 2:
                    print("Back");
                    break;
            }


    }
}