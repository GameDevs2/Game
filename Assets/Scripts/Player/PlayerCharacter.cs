using UnityEngine;

public class PlayerCharacter : MonoBehaviour {
    // Modified used to set player speed
    private static float speedModifier = 3.0F;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        movePlayer();

        // Move camera with mouse
        lookTowardsMouse();
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

        transform.Translate(direction.normalized * (Time.deltaTime * speedModifier), Space.Self);
    }

    private void lookTowardsMouse()
    {
        var newMousePos = new Vector2(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"));
        transform.eulerAngles = transform.eulerAngles - new Vector3(newMousePos.x, newMousePos.y);
    }
}
