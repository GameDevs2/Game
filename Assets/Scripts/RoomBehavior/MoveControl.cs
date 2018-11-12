using UnityEngine;

public class MoveControl : MonoBehaviour {
    public Vector3 AddRotation;
    float lastTriggeredTime = float.NegativeInfinity;
    float cooldownTime = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<PlayerCharacter>() == null)
        {
            return;
        }

        if (Time.time - lastTriggeredTime > cooldownTime)
        {
            lastTriggeredTime = Time.time;
            GameObject room = GameObject.Find("Room");
            room.GetComponent<Room>().AddTargetRotation(AddRotation);
        }
	}
}
