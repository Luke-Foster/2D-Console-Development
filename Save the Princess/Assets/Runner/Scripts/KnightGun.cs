using UnityEngine;
using System.Collections;

public class KnightGun : MonoBehaviour {

	public Rigidbody2D Gust;				// Prefab of the gust
	public float speed = 20f;				// The speed the gust will fire at.
	
	
	private PlayerControl playerCtrl;		// Reference to the PlayerControl script.
	private Animator anim;					// Reference to the Animator component.
	
	
	void Awake()
	{
		// Setting up the references.
		anim = transform.root.gameObject.GetComponent<Animator>();
		playerCtrl = transform.root.GetComponent<PlayerControl>();
	}
	
	
	void Update ()
	{
		// If the fire button is pressed...
		if(Input.GetButtonDown("Fire1"))
		{
			// ... set the animator Shoot trigger parameter and play the audioclip.
			anim.SetTrigger("Shoot");
			
			// If the player is facing right...
			if(playerCtrl.facingRight)
			{
				StartCoroutine(ShootRight());
			}
			else
			{
				StartCoroutine(ShootLeft());
			}
		}
	}
	IEnumerator ShootRight() {
		// ... instantiate the gust facing right and set it's velocity to the right. 
		yield return new WaitForSeconds(0.5f);
		Rigidbody2D bulletInstance = Instantiate(Gust, transform.position, Quaternion.Euler(new Vector3(0,-2f,0))) as Rigidbody2D;
		bulletInstance.velocity = new Vector2(speed, 0);
	}
	IEnumerator ShootLeft() {
		// Otherwise instantiate the gust facing left and set it's velocity to the left.
		yield return new WaitForSeconds(0.5f);
		Rigidbody2D bulletInstance = Instantiate(Gust, transform.position, Quaternion.Euler(new Vector3(0,-2f,180f))) as Rigidbody2D;
		bulletInstance.velocity = new Vector2(-speed, 0);
	}
}
