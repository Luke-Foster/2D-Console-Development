using UnityEngine;
using System.Collections;

public class RunnerCamera : MonoBehaviour {

	public PlayerControl ThePlayer;
	private Vector3 PlayerPosition;
	private float DistanceToMove;

	void Start () 
	{
		ThePlayer = FindObjectOfType<PlayerControl>(); // find the playercontrol script
		PlayerPosition = ThePlayer.transform.position;
	}

	void Update () 
	{
			DistanceToMove = ThePlayer.transform.position.x - PlayerPosition.x; // calculate movement
			transform.position = new Vector3 (transform.position.x + DistanceToMove, transform.position.y, transform.position.z); // set new position
			PlayerPosition = ThePlayer.transform.position; 
	}
}
