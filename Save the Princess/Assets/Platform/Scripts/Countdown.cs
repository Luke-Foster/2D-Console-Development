using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

	public float timeLeft = 300.0f;
	public GameObject Princess;
	public GameObject PrincessText;
	public Text text;
	
	
	
	void Update()
	{
		timeLeft -= Time.deltaTime; // lower time left based on time
		text.text = "Time Left:" + Mathf.Round(timeLeft); // round the time to display whole numbers only
		if(timeLeft <= 1)
		{
			Application.LoadLevel(0);
		}
		else if (timeLeft <= 10)
		{
			// remove the princess text
			PrincessText.SetActive (false);
		}
		else if (timeLeft <= 15) {
			// display the princesstower & Text to inform the user
			Princess.SetActive (true);
			PrincessText.SetActive (true);
		}
	}
}