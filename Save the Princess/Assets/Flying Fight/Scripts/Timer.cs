using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text text;
	public float timeTotal = 0f;
	public PlayerSpawner spawnerscript; // refers to the player spawner script
	
	// Update is called once per frame
	void Update () {
		if (spawnerscript.numLives >= 1) // references the numLives variable from the player spawner script
		{
			timeTotal += Time.deltaTime; // increases total time based on time that has passed
			text.text = "Time Survived: " + Mathf.Round (timeTotal); // round the time to display whole numbers only
		}
	}
}
