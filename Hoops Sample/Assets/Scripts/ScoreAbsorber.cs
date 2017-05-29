using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAbsorber : MonoBehaviour {
	public int scoreFromLevel;

	// Use this for initialization
	void Start () {
		ScoreKeeper oldScoreKeeper = FindObjectOfType<ScoreKeeper>();
		scoreFromLevel = 1;
		if (oldScoreKeeper) {
			scoreFromLevel = oldScoreKeeper.score;
			Destroy(oldScoreKeeper.gameObject);
			print(scoreFromLevel);
		}


	}
	
	// Update is called once per frame
	void Update () {
	//	scoreTxt.text = "Your score is " + scoreFromLevel;

	}
}
