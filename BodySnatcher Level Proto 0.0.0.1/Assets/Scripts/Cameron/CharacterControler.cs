using UnityEngine;
using System.Collections;

public class CharacterControler : MonoBehaviour
{
    public float Speed;
    // Use this for initialization
    void Start()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "diggable")
        {
            if (Input.GetButtonDown("Jump"))
            {
                other.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= Speed;
        moveDirection.y -= 9.8f * Time.deltaTime;
        GetComponent<CharacterController>().Move(moveDirection * Time.deltaTime);
    }
}
