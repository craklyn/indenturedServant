using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour {
	public Text textBox;

	int storyLine = -1;
	public AudioClip audio1, audio2, audio3, audio4, audio5, audio6, audio7, audio8, audio9, audio10, audio11, audio12;

	//private States myState;
//	private int pageNumber = 0;
	private string[] sentences = new string[] {
		"It another day…. Me hope it no rain.... Me never thought me be a fisherman. See me now! So far from me home in the small village where me born.", 
		"Me local school closed, when me just a little pickney. Me parents put me in the private school. I go to the top of me class.", 
		"I get home to find me papa lying real still like on the floor. Me rush him to the medic, but me miss the school day.",
		"The doctors say they help me papa… but only if we pay the bribe money.", 
		"Me mother gave them everything we had.  But he die anyway, just a week later.", 
		"I return to school. They say I can finish me classes.  But me no graduate unless me pay the last bit of the tuition.",
		"Me found out Papa in debt. He lend the money from a man to pay for me schooling. Me his only pickney - now it’s up to me to pay it back.", 
		"The next day, me get a hospital bill.", 
		" Me must help mama pay the debt. Me must get a job.",
		"Me go up and down the road, here and there. Me talk to everyone. But no one want to give me a job.", 
		"Me find this man. He make me lots of promises. He say, ‘Go to America. I find you opportunities and I help you pay your family debt.’", 
		"Me took the deal, but before me go, me must work on this fishing boat. Me sort the fish every day, until me pay the passage and pay me debt."};



	// Use this for initialization
	void Start () {
		//myState = States.pageNumber;
	}

	// Update is called once per frame
	void Update ()
	{
		AudioClip[] audioFiles = {
			audio1,
			audio2,
			audio3,
			audio4,
			audio5,
			audio6,
			audio7,
			audio8,
			audio9,
			audio10,
			audio11,
			audio12
		};

		AudioSource audio = GetComponent<AudioSource> ();
		//print (myState);
		if (Input.GetKeyDown (KeyCode.RightArrow) || (storyLine != -1 && !audio.isPlaying) || 
			OVRInput.GetDown (OVRInput.Button.One) || OVRInput.GetDown (OVRInput.Button.Two) || OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) || OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
		{
			storyLine += 1;

			if(storyLine < sentences.Length) {
				audio.clip = audioFiles [storyLine];
				audio.Play();
				textBox.text = sentences[storyLine];
				//audio.clip = "Narration_" + storyLine;
			}
			else {
				LoadNextScene();
			} 
		}


	}

	public void LoadNextScene ()
	{
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentIndex + 1);


	}
	}


