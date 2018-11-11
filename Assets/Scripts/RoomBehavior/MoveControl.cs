using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
		if (other.GetComponent<PlayerCharacter>() != null){
			GameObject room = GameObject.Find("Room");
			room.GetComponent<Room>().setTargetRotation(new Vector3(90, 0, 0));
		}
	}
}
