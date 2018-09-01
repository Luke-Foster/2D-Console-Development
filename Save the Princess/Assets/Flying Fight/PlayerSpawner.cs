using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerSpawner : MonoBehaviour {

	public GameObject playerPrefab; //prefab for spawning the player
	GameObject playerInstance; // tracked version of player

	public GameObject Image;
	public GameObject Title;
	public Button Retry;
	public Button Quit;
	public GameObject RetryVisibility;
	public GameObject QuitVisibility;

	public int numLives = 4; // number of lives

	float respawnTimer; // how long it takes to respawn

	// Use this for initialization
	void Start () 
	{
		Retry = Retry.GetComponent<Button> (); 
		Quit = Quit.GetComponent<Button> ();
		SpawnPlayer(); // run the spawnplayer function
	}

	void SpawnPlayer() 
	{
		numLives--; // remove a life
		respawnTimer = 2; // set respawn time
		playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity); // spawn and track object
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(playerInstance == null && numLives > 0) { // check for instance and lives
			respawnTimer -= Time.deltaTime; // decrease the respawnTimer over time

			if(respawnTimer <= 0) { // if the respawn timer is 0 spawn player
				SpawnPlayer();
			}
		}
	}

	void OnGUI() 
	{
		if(numLives > 0 || playerInstance!= null) {
			GUI.Label( new Rect(0, 0, 100, 50), "Lives Left: " + numLives); // create a GUI element that displays the amount of lives you have left
		}
		else 
		{
			RetryVisibility.SetActive (true);
			QuitVisibility.SetActive (true);
			Image.SetActive (true);
			Title.SetActive (true);
		}
	}

	public void Restart()
	{
		Application.LoadLevel (2);   // restarts level by loading the same scene again
	}
	public void MainMenu()
	{
		Application.LoadLevel (0);   // Send user back to start menu
	}
}
