using UnityEngine;
using System.Collections;

public class Terrain_Vert4Pos_Creator : MonoBehaviour
{
    //I will be determining each and every vertice i have in my collection, but will only assign vertices to a collection if the collection is required and is attatched.
    //This means i will only record verticies locations to the Collection if its both in range and i can tell in what it needs to know within its list/array of infomation.


    //<<If transform position != new transform position update the transform mesh of this game object.>>



    //////////////// Use this for initialization
    void Start()
    {
        Vector3.Distance(vec1, vec2);
    }

    //////////////// Update is called once per frame
    void update()
    {

    }
}





///External notes:
///Collections will be attached to the Grave set which will hold all the infomation of the range and sizes of graves as well as truncate anything that is not in range to be ignored.