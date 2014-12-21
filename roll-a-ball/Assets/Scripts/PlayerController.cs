using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

	public float speed;

	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 vector = new Vector3 (moveHorizontal, 0f, moveVertical);

		rigidbody.AddForce (vector * speed * Time.deltaTime);	
	}
}