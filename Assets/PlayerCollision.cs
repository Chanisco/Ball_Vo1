using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {
	
	
	public static int count;
	Vector3 Spawn;
	public GameObject Lvl1;
	public GameObject Lvl2;
	public GameObject Lvl3;
	public GameObject Lvl4;
	public GameObject Lvl5;
	
	
	// Use this for initialization
	void Start () {
		count = 0;
		Spawn = new Vector3(0,20,0);
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		if(other.tag == Tags.collectable){
			other.gameObject.SetActive(false);
			count += 1;
		}
	}
	
	void OnCollisionEnter(Collision col)
	{
		if(col.collider.name == "Ground"){
			rigidbody.AddRelativeForce(0,0,2000);
		}
		if(col.collider.name == "Restart"){
			rigidbody.AddRelativeForce(0,1000,0);
		}
		if(col.collider.name == "Plane2")
		{
			Lvl1.SetActive(false);
		}
	}
}
