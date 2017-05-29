using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishLauncher : MonoBehaviour {
	public GameObject SardinesPrefabs;
	public float speed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1")) {
			GameObject ball = Instantiate (SardinesPrefabs);
			ball.transform.position = transform.position ;
			Rigidbody rb = ball.GetComponent<Rigidbody> ();

	//		Camera camera = GetComponentInChildren<Camera>();
	//		camera.transform.localRotation = camera.transform.localRotation;

			rb.velocity = GetComponent<Camera>().transform.rotation * Vector3.forward * speed  ;

			//camera.transform.rotation * Vector3.forward;
		}
	}
}
