using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour {



	// Use this for initialization
	void Start () {
		RenderSettings.fogColor = Color.blue;
		RenderSettings.fog = true;		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
