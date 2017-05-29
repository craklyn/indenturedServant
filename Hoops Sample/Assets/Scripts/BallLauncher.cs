using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {
	public GameObject ballPrefab;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1")) {
			GameObject ball = Instantiate (ballPrefab);
			ball.transform.position = transform.position ;
			Rigidbody rb = ball.GetComponent<Rigidbody> ();

			Camera camera = GetComponentInChildren<Camera>();
			camera.transform.localRotation = camera.transform.localRotation;

			rb.velocity = camera.transform.rotation * Vector3.forward * speed  ;

			//camera.transform.rotation * Vector3.forward;
		}
	}
}
