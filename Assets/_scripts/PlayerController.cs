using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float jump = Input.GetKeyDown (KeyCode.Space) ? 2 : 0;

		Vector3 movement = new Vector3 (moveHorizontal, jump, moveVertical );

		rb.AddForce (movement * speed);
	}

}
