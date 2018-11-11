using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    // Player level motion override, used to ignore input when focus not on player.
    public bool CanMove { get; set; }

    // Modified used to set player speed
    private static float speedModifier = 3.0F;
    private static float headZBaseRot = 5.177F;

    // Use this for initialization
    void Start () {
        this.CanMove = true;
	}
	
	// Update is called once per frame
	void Update () {
        // Ignore input if the player can't currently move
        if (CanMove) { movePlayer(); }

        // Move camera with mouse
        lookTowardsMouse();
    }

    private void OnGUI()
    {


    }

    private void movePlayer() {
        Vector3 direction = Vector3.zero;


        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }

        transform.Translate(direction.normalized * (Time.deltaTime * speedModifier), Space.World);
    }

    private void lookTowardsMouse()
    {

        // Figure out new rotation rotation
        float horizontal = 0.5F * Input.GetAxis("Mouse X");
        float vertical = 0.5F * -Input.GetAxis("Mouse Y");
        Vector3 newRotation = transform.eulerAngles - new Vector3(vertical, horizontal, 0);

        // Need to bind the vertical axis

        //Don't allow rotating too far or things get weird
        transform.eulerAngles = newRotation;
    }

}
