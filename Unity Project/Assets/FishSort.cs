﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.UI;
using UnityEngine.VR.WSA;

public class FishSort : MonoBehaviour
{
    private int sorted_fish_value;
    public int sorted_fish
    {
        get { return sorted_fish_value; }
        set
        {
            sorted_fish_value = value;
            textObject.text = sorted_object.type + "s sorted: \n" + sorted_fish_value;
        }

    }
    public FishData sorted_object;
    public Text textObject;
    public Countdown timer;
    

	// Use this for initialization
	void Start ()
	{
	    sorted_fish = 0;

	}
	
	// Update is called once per frame
	void Update () {
        
        
	}

    private void OnTriggerEnter(Collider other)
    {
        FishData data = other.GetComponent<FishData>();
        if (data != null && data.type.Equals( sorted_object.type))
        {
           if (timer.isCountingDown)
            {
                sorted_fish++;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FishData data = other.GetComponent<FishData>();
        if (data != null && data.type.Equals(sorted_object.type))
        {
            if (timer.isCountingDown)
            {
                sorted_fish--;
            }

        }
    }


}
