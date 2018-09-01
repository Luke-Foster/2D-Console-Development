using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelLoad : MonoBehaviour {

	public Button Image;
	public GameObject ImageVisibility;
	public int LevelNum = 0;

	// Use this for initialization
	void Start () {
		Image = Image.GetComponent<Button> (); 
	}
	
	public void LoadLevel()
	{
		Application.LoadLevel (LevelNum);   // Send user back to start menu
	}
}
