using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    [Tooltip("This will follow the player as you play via rotation if unlocked or if locked the rotation won't rotate. Their will also be a position lock to stop the camera over traveling.")]
    public Camera lockToPlayer;

    [Tooltip("Key's for moveDirection are from 0-3 in the order of W, A, S, D as STANDARD keys.")]
    //Key's 0-3 are W, A, S, D.
    public KeyCode[] moveDirection = {KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D};

	// Use this for initialization
	void Start () {
	
	}
	
    void MoveDirection()
    {
        Debug.Log("Key's presses function active line 20.");
    }

	// Update is called once per frame
	void Update () {

        ////////if (Input.GetKey (moveDirection[0]))
        ////////{ }

        ////////if(Input.GetKey (moveDirection[0]) || Input.GetKey (moveDirection[1]) || Input.GetKey (moveDirection[2]) || Input.GetKey (moveDirection[3]))
        ////////{ }

        {
            int i = 0;
            foreach (KeyCode move in moveDirection)
            {
                if(Input.GetKey (moveDirection[i]))
                { MoveDirection(); }
                i++;
            }
        }
        Debug.Log("No Movement...");
        //Test for movement and direction.
	
	}
}
