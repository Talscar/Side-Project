using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    [Tooltip("This will follow the player as you play via rotation if unlocked or if locked the rotation won't rotate. Their will also be a position lock to stop the camera over traveling.")]
    public Camera lockToPlayer;

    [Tooltip("Key's for moveDirection are from 0-3 in the order of W, A, S, D as STANDARD keys.")]
    //Key's 0-3 are W, A, S, D.
    public KeyCode[] moveDirection = {KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D};
    int speedcon = 0;
    public float walk = 6.2f;
    public KeyCode Sprint = KeyCode.LeftShift;
    public float run = 12.4f; //multiplier
    private float movementRate = 0.0f;
    private bool isMoving;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
    void MoveDirection()
    {

        //Vector3 force_Direction = new Vector3("Horizontal");
        Debug.Log("Key's presses function active line 20."); 
        Vector3 location = new Vector3 (0, 0, 0);
//        new Vector3 variableMovement = new Vector3(0, 0, 0);
        if (Input.GetKey(moveDirection[0]))
        {
            //Ray fowards = new Ray Forward;
            /*gameObject.transform.position = gameObject.transform.position +*/ location = location + Vector3.forward/*new Vector3(0, 0, ((walk / speedcon) * Time.deltaTime))*/;
        }
        if (Input.GetKey(moveDirection[1]))
        {
            location = location + Vector3.left; //gameObject.transform.position = gameObject.transform.position + new Vector3(-((walk /speedcon) * Time.deltaTime), 0, 0); 
        }
        if (Input.GetKey(moveDirection[2]))
        {
            location = location + Vector3.back;//gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, -((walk / speedcon) * Time.deltaTime));
        }
        if (Input.GetKey(moveDirection[3]))
        {
            location = location + Vector3.right;//gameObject.transform.position = gameObject.transform.position + new Vector3(((walk / speedcon) * Time.deltaTime), 0, 0);
        }
        if(location.x == location.z || location.z < 0 && location.x > 0 || location.x < 0 || Input.GetKey (moveDirection[0]) && Input.GetKey (moveDirection[2]) || Input.GetKey (moveDirection[1]) && Input.GetKey (moveDirection[3])) 
//Trying to smooth out the buggyness of movement. failing with the array of 0 and 2 if 3 is pressed controller breaks.
        { movementRate = movementRate / 2; }
        gameObject.transform.position = gameObject.transform.position + new Vector3(location.x * (movementRate * Time.deltaTime), location.y * (movementRate * Time.deltaTime), location.z * (movementRate * Time.deltaTime));
        Debug.Log(location);
        isMoving = true;
    }

	// Update is called once per frame
	void FixedUpdate () {


        ////////if (Input.GetKey (moveDirection[0]))
        ////////{ }

        ////////if(Input.GetKey (moveDirection[0]) || Input.GetKey (moveDirection[1]) || Input.GetKey (moveDirection[2]) || Input.GetKey (moveDirection[3]))
        ////////{ }
        if(isMoving)
        { }

        if(Input.GetKey (Sprint))
        { movementRate = run; }
        else { movementRate = walk; }
        {
            int i = 0;
            int icount = 0;
            foreach (KeyCode move in moveDirection)
            {
                if(Input.GetKey (moveDirection[i]))
                { icount++; speedcon = icount; MoveDirection(); }
                i++;
                if (i == 0)
                { isMoving = false; }
            }
        }
        Debug.Log("No Movement...");
        //Test for movement and direction.
	
	}
}
//commit changes.
