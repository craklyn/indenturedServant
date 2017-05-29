using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {
	float speed = 1.0f;
	// Update is called once per frame
	void Update () {
		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = Input.GetAxis("Mouse Y");
		transform.rotation = transform.rotation * Quaternion.Euler(0, mouseX* speed, 0) ;
		Camera camera = GetComponentInChildren<Camera>();
		camera.transform.localRotation = camera.transform.localRotation * Quaternion.Euler(-mouseY* speed, 0 , 0) ;



			}
}
