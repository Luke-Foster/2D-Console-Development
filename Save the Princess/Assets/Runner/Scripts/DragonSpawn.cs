using UnityEngine;
using System.Collections;

public class DragonSpawn : MonoBehaviour {

	public GameObject Dragon;

	void OnTriggerEnter2D()
	{
		Dragon.SetActive (true); // when you go through the end collider make the dragon visible
	}
}
