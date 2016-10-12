using UnityEngine;
using System.Collections;

public class Deformer : MonoBehaviour {

    //I will be pushing terrain into the ground, and be limited to rising to the top and no more.
    //My travel range is on the Y axis and can use my contact points in the mesh to transform the terrain.
    //I have a limit depending on what vertices are on the inside location of the (Grave Set) << Grave set is to locate deformers, bodys and other things as well as set range. Anything outside of it's range will be made redundent for use in this script.


    ///I will function by finding the closest vertices to my position, getting that position and claiming it as my own.
    ///Once i have collected that position, no other vertices can take that position and modify it, due to a bool check which when true means others know "I can't occupie this space, another already claimed it".
    ///




	//////////////// Use this for initialization
	//////////////void Start () {
	
	//////////////}
	
	//////////////// Update is called once per frame
	//////////////void Update () {
	
	//////////////}
}
