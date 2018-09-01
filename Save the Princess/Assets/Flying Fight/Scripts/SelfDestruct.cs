using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

	public float timer = 1f;

	void Update () {
		// cleanup for objects that don't need to be around forever, no forever flying fireballs
		timer -= Time.deltaTime;

		if(timer <= 0) {
			Destroy(gameObject);
		}
	}
}
