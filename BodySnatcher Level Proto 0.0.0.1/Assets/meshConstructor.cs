using UnityEngine;
using System.Collections;
using System;

public class meshConstructor : IComparable<meshConstructor>
{
    //already has the number value of the vert.
    public int counter;
    //public float[] vert4 = {0, 0, 0, 0};
    public float vert4_x;
    public float vert4_y;
    public float vert4_z;

    public meshConstructor(float new_vert4_x, float new_vert4_y, float new_vert4_z, int new_Counter)
    {
        vert4_x = new_vert4_x;
        vert4_y = new_vert4_y;
        vert4_z = new_vert4_z;
        counter = new_Counter;
    }

    public int CompareTo(meshConstructor other)
    {
        if (other == null)
        {
            return 1;
        }
        return counter - other.counter;
    }

}
