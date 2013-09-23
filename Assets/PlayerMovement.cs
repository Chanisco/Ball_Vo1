using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	public float speed;
	//----je kunt je referenties opzoeken via ' CMD ' en " ' " 
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalMovement = Input.GetAxis("Horizontal");
		float verticalMovement = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(horizontalMovement,0.9f,verticalMovement);
		rigidbody.AddForce(movement * speed * Time.deltaTime);
		/*rigidbody.velocity = Vector3.zero;
		if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D)){
			rigidbody.AddRelativeForce(500,0,0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A)){
			rigidbody.AddRelativeForce(-500,0,0);
		}
		if(Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.W)){
			rigidbody.AddRelativeForce(0,0,500);
		}
		if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S)){
			rigidbody.AddRelativeForce(0,0,-500);
		}*/
	}
}
