using UnityEngine;
using System.Collections;

public class Princess : MonoBehaviour {

	public GameObject princess;
	public GameObject stalker;
	public GameObject win;
	public GameObject Bye;

	void OnTriggerEnter2D() 
	{
		// Sets the stalker princess to active and removes the one from the tower as well as activated the win condition collider
		princess.SetActive (false);
		stalker.SetActive (true);
		win.SetActive (true);
		Bye.SetActive (true);
	}
}
