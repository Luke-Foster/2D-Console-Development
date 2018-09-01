using UnityEngine;
using System.Collections;

public class Bye : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{  
		Destroy (col.gameObject);
	}
}
