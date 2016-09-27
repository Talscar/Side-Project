using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class Custom_Shape : MonoBehaviour {

    public List<Vector3> points = new List<Vector3>();


    public bool pointToClick = false;
    public float vert_PartDistance = 1;
    public int vert_RowCount = 10;
    public int vert_CollumCount = 10;
    public float vertCount;

   // [Range(x, z)]
    [Range(0, 2)]
    public int axis = 1;
    public char axis3;
    Char[] direction = { 'x', 'y', 'z'};
    bool Direction_x = false;
    bool Direction_y = false;
    bool Direction_z = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        vertCount = vert_CollumCount * vert_RowCount;

        if(direction[axis] != axis3)
        {
            Direction_x = false;
            Direction_y = false;
            Direction_z = false;
            axis3 = direction[axis];
            if(axis3 == 'x')
            { Direction_x = true;}
            if (axis3 == 'y')
            { Direction_y = true;}
            if (axis3 == 'z')
            { Direction_z = true; }
        }

        if(pointToClick)
        {
            if(Direction_x)
            {
                if(Input.GetMouseButtonDown(0))//.GetButtonDown("0"))
                { Debug.Log("Button Rectified x direction."); }
            }

            if (Direction_y)
            {
                if (Input.GetMouseButtonDown(0))//.GetButtonDown("0"))
                { Debug.Log("Button Rectified y direction.");
                  
                }
            }

            if (Direction_z)
            {
                if (Input.GetMouseButtonDown(0))//.GetButtonDown("0"))
                { Debug.Log("Button Rectified z direction."); }
            }
        }

	
	}
}
