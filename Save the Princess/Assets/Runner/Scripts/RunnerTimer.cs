using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RunnerTimer : MonoBehaviour {

	public Text text;
	public float timeTotal = 0f;

	void Update () {

			timeTotal += Time.deltaTime; // increases total time based on time that has passed
			text.text = "Time Taken: " + Mathf.Round (timeTotal); // round the time to display whole numbers only
		
	}
}
