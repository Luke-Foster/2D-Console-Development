using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
	public float moveSpeed = 2f;		// The speed the enemy moves at.
	public int HP = 1;					// How many times the enemy can be hit before it dies.
	public AudioClip[] deathClips;		// An array of audioclips that can play when the enemy dies.
	public GameObject hundredPointsUI;	// A prefab of 100 that appears when the enemy dies.
	public float deathSpinMin = -100f;			// A value to give the minimum amount of Torque when dying
	public float deathSpinMax = 100f;			// A value to give the maximum amount of Torque when dying
	public float attackCooldown = 0f;

	Transform target;

	private Transform frontCheck;		// Reference to the position of the gameobject used for checking if something is in front.
	private bool dead = false;			// Whether or not the enemy is dead.
	private Animator anim;
	

	void Awake()
	{
		// Setting up the references.
		//score = GameObject.Find("Score").GetComponent<Score>();
		anim = GetComponent<Animator>();
	}

	void Update ()
	{
		if (transform.rotation.z != 0) {
			transform.rotation = Quaternion.Euler(0,0,0);
		}
		attackCooldown -= Time.deltaTime;;
	}
	
	void FixedUpdate ()
	{
		target = GameObject.FindWithTag ("Player").transform; // find the player and set as target
		
		Vector3 forwardAxis = new Vector3 (0, 0, -1);
		
		
		
		//look at the target and move towards the target constantly
		transform.LookAt (target.position, forwardAxis);
		Debug.DrawLine (transform.position, target.position);
		transform.eulerAngles = new Vector3 (0, 0, -transform.eulerAngles.z);
		transform.position -= transform.TransformDirection (Vector2.up) * moveSpeed ;

		Vector3 myself = this.transform.position;
		float dist = Vector3.Distance(target.position, myself);
		if( dist < 5f && attackCooldown < 1f) {
			anim.SetTrigger("Shoot");
			attackCooldown = 2f;
		}
		// If the enemy has zero or fewer hit points and isn't dead yet...
		if(HP <= 0 && !dead)
			// ... call the death function.
			Death ();
	}
	
	public void Hurt()
	{
		// Reduce the number of hit points by one.
		HP--;
	}
	
	void Death()
	{

		// Set dead to true.
		dead = true;

		// Allow the enemy to rotate and spin it by adding a torque.
		GetComponent<Rigidbody2D>().fixedAngle = false;
		GetComponent<Rigidbody2D>().AddTorque(Random.Range(deathSpinMin,deathSpinMax));

		// Find all of the colliders on the gameobject and set them all to be triggers.
		Collider2D[] cols = GetComponents<Collider2D>();
		foreach(Collider2D c in cols)
		{
			c.isTrigger = true;
		}
	}
}
