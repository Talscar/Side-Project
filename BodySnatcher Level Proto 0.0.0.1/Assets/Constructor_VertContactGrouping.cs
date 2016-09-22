using UnityEngine;
using System.Collections;
using System;

public class Constructor_VertContactGrouping : IComparable<Constructor_VertContactGrouping> {

    public int point_Modifier_Identity = 0;
    public float[] point1 = {0, 0, 0};
    public float[] point2 = {0, 0, 0};
    

    public Constructor_VertContactGrouping()
    { }
	
    public int CompareTo(Constructor_VertContactGrouping other)
    {
        if(other == null)
        {
            return 1;
        }

        return point_Modifier_Identity - point_Modifier_Identity;
    }
} //24 lines total here.



///<Msg This script will store infomation about a group of verts to modify the terrain. this will then control
///Which grouping of points it will use. Contact point 1 been a singular grouping for testing and checking. Where it checks
/// if one vert is close to another. If it is, then it will store the infomation of point2 which is closest to itself. IT will then take that infomation for future use.
/// The infomation will be manipulated to move verts up and down with a object. We will also have a reset button if need be.
