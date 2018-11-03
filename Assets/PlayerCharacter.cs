using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnGUI()
    {
        Vector3 direction;
        var currentEvent = Event.current;
        if (!currentEvent.isKey)
        {
            return;
        }
        switch (currentEvent.keyCode)
        {
            case KeyCode.UpArrow:
                direction = Vector3.forward;
                break;
            case KeyCode.DownArrow:
                direction = Vector3.back;
                break;
            case KeyCode.LeftArrow:
                direction = Vector3.left;
                break;
            case KeyCode.RightArrow:
                direction = Vector3.right;
                break;
            default:
                return;
        }

        transform.Translate(direction * Time.deltaTime, Space.World);
    }


}
