using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	public GameObject player ;
	public Vector3 offset;
	// Use this for initialization
	void Start () {
	offset = transform.position;
	player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
		
	}
}
