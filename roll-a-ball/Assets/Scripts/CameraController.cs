using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject playerObject;
	private Vector3 offset;

	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = playerObject.transform.position + offset;
	}
}
