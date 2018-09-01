using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour {

	public GameObject Image;
	public GameObject Title;
	public Button Retry;
	public Button Quit;
	public GameObject RetryVisibility;
	public GameObject QuitVisibility;
	public GameObject Timey;

	void Start () 
	{
		Retry = Retry.GetComponent<Button> (); 
		Quit = Quit.GetComponent<Button> ();
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			RetryVisibility.SetActive (true);
			QuitVisibility.SetActive (true);
			Image.SetActive (true);
			Title.SetActive (true);
			Timey.SetActive (false);
		}
	}

	public void Restart()
	{
		Application.LoadLevel (3);   // restarts level by loading the same scene again
	}
	public void MainMenu()
	{
		Application.LoadLevel (0);   // Send user back to start menu
	}
}
