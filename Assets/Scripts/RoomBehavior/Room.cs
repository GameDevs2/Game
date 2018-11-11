using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {

	private Vector3 targetRotation = new Vector3(0,0,0);
	private readonly float rotationTime = 3;
	private Vector3 lastRotation;
	private float startTime = 0;

	public void setTargetRotation(Vector3 newRotation){
		this.lastRotation = this.transform.eulerAngles;
		this.targetRotation = newRotation;
		this.startTime = Time.time;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		this.transform.eulerAngles = Vector3.Lerp(this.lastRotation, this.targetRotation, ((Time.time - this.startTime) / this.rotationTime));

	}
}
