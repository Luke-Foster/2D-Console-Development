using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuQuit : MonoBehaviour {

	public Button Quit;

	void Start () 
	{ 
		Quit = Quit.GetComponent<Button> ();    
	}

	public void MainMenu()
	{
		Application.LoadLevel (0);   // Send user back to start menu
	}
}
