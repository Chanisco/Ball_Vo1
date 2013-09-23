using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	public static int maxCollectables;
	// Use this for initialization
	void Start () {
		GameObject[] collectables = GameObject.FindGameObjectsWithTag(Tags.collectable);
		maxCollectables = collectables.Length;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(100,0,0) * Time.deltaTime);
	}
}
