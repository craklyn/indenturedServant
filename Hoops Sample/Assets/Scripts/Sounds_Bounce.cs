using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds_Bounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision collision)
	{
		AudioSource source = GetComponent<AudioSource>();
		source.Play();
	}
}
