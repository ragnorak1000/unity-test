using UnityEngine;
using System.Collections;

public class PickupRotator : MonoBehaviour {

	public Vector3 rotator; 

	void Update () {
		transform.Rotate (rotator * Time.deltaTime);
	}
}
