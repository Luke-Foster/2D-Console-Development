using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab;

	float spawnDistance = 12f;

	float enemyRate = 6;
	float nextEnemy = 1;

	// Update is called once per frame
	void Update () {
		nextEnemy -= Time.deltaTime; // use time to determine when to spawn the new enemy

		if(nextEnemy <= 0) {
			nextEnemy = enemyRate; // reset spawn time
			enemyRate *= 0.9f; // lower enemy rate for increasing diffculty
			if(enemyRate < 2)
				enemyRate = 2; // set every 2 seconds to lowest possible, for performance purposes mainly

			Vector3 offset = Random.onUnitSphere; 

			offset.z = 0;

			offset = offset.normalized * spawnDistance;

			Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity); 
			// spawn the enemy at a random position over 12f from the player spawn
		}
	}
}
