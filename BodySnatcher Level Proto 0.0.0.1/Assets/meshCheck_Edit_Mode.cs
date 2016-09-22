using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class meshCheck_Edit_Mode : MonoBehaviour {

    public float vert4_interact;
	
    void OnCollisionStay(Collision collider)
    {

    }
	// Update is called once per frame
	void Update () {
        vert4_interact = gameObject.transform.position.y;
	
	}
}
