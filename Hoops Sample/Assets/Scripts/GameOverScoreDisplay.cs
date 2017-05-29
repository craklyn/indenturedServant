using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {
	Text gameOverScoreText;
	ScoreAbsorber score;
	// Use this for initialization
	void Start () {
		gameOverScoreText = GetComponent<Text>();
		score = FindObjectOfType<ScoreAbsorber>();
			
	}
	
	// Update is called once per frame
	void Update () {
		gameOverScoreText.text = "Score is: " + score.scoreFromLevel; 

	}
}
