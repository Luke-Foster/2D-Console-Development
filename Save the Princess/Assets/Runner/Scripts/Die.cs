using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

	public GameObject Character;
	public GameObject Spawn;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") {
			Character.transform.position = Spawn.transform.position; // send the player back to spawn if they fall off the map
		} 
		else 
		{
			Destroy(col.gameObject); // destroy anything that isn't the player that falls off the map
		}
	}
}
