using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndGame : MonoBehaviour {

	public GameObject Image;
	public GameObject Title;
	public Button Retry;
	public Button Quit;
	public GameObject RetryVisibility;
	public GameObject QuitVisibility;
	public GameObject Timer;
	public GameObject EndClear;
	public GameObject Character;
	public GameObject EndDestroyer;
	public GameObject Spawner1;
	public GameObject Spawner2;
	public GameObject Fake;
	public GameObject MainCamera;
	public GameObject Centre;

	void Start () 
	{
		Retry = Retry.GetComponent<Button> (); 
		Quit = Quit.GetComponent<Button> ();    
	}

	void OnTriggerEnter2D(Collider2D col)
	{  
		if (col.gameObject.tag == "Player") 
		{
			// if the player is in the collider then gameobjects are set to become active or hide and the main camera is moved to its central position
			RetryVisibility.SetActive (true);
			QuitVisibility.SetActive (true);
			Image.SetActive (true);
			Title.SetActive (true);
			Timer.SetActive (false);
			EndClear.SetActive (true);
			Character.SetActive (false);
			EndDestroyer.SetActive (true);
			Spawner1.SetActive (false);
			Spawner2.SetActive (false);
			Fake.SetActive (true);
			MainCamera.transform.position = Centre.transform.position;
		}
	}
	
	
	public void Restart()
	{
		Application.LoadLevel (1);   // restarts level by loading the same scene again
	}
	public void MainMenu()
	{
		Application.LoadLevel (0);   // Send user back to start menu
	}
}
