using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {
	
	public GameObject youWin;
	// Use this for initialization
	void Awake (){
		youWin.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text ="Score: " + PlayerCollision.count.ToString();
		if(PlayerCollision.count == Rotate.maxCollectables){
			Winning ();	
		}
	}
	void Winning(){
		youWin.SetActive(true);
	}
}
