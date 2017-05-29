using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {
	LevelManager levelManager;
	Text timeRemainingTxt;
	// Use this for initialization


	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
		timeRemainingTxt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	//	LevelManager timeLeft = FindObjectOfType<Update>();
		timeRemainingTxt.text = "Time remaining: " + levelManager.timeTillNextLevel;

	}
}
