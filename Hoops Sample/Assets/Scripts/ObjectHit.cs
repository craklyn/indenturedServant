using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour {
	public int factor;
	// Use this for initialization
	public void OnCollisionEnter (Collision collision)
	{
		ScoreKeeper score = FindObjectOfType<ScoreKeeper>();
		score.IncrementScore(factor);
		print("Score is: " + score.score);
						
	}
}
