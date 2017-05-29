using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeDeath : MonoBehaviour
{

    public bool timerStarted = false;
    public float delayToDisappear;

    private float deathTimer;

	// Use this for initialization
	void Start ()
	{

	    deathTimer = delayToDisappear;

	}
	
	// Update is called once per frame
	void Update () {
	    if (!timerStarted)
	    {
	        return;
	    }
	    if (deathTimer > 0)
	    {
	        deathTimer -= Time.deltaTime;
	    }

	    else
	    {
	        GameObject.Destroy(gameObject);
	    }
		
	}
}
