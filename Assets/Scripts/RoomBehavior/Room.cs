using UnityEngine;

public class Room : MonoBehaviour {
	private Vector3 targetRotation = new Vector3(0,0,0);
	public float rotationTime = 1;
	private Vector3 lastRotation;
	private float startTime = 0;

	public void AddTargetRotation(Vector3 newRotation){
		lastRotation = transform.eulerAngles;
		targetRotation += newRotation;
		startTime = Time.time;
	}

	// Use this for initialization
	void Start () {
        targetRotation = transform.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = Vector3.Lerp(lastRotation, targetRotation, ((Time.time - startTime) / rotationTime));
	}
}
