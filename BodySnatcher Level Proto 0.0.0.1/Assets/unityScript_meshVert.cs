using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//[ExecuteInEditMode]
public class unityScript_meshVert : MonoBehaviour {
    //  public bool requestPull = true;
    //  private bool standardTest = false;
    //  public bool complicatedBuild = true;

    //  public float time = 15f;
    //  float count = 0.0f;
    public bool bootCall = true;
    bool switche = true;
    Mesh mesh;

    List<meshConstructor> vert4 = new List<meshConstructor>();

    public float movement = 50.0f;

    void OnCollision(Collision collider)
    {

    }
    

    void OnCollisionStay(Collision collider)
    {

        foreach (ContactPoint point in collider)
        {
            Debug.Log(point.point); //point.point is a vector 3 location for that contact point.
            
            

        }
        //foreach (ContactPoint contact in collider.contacts)
        //{
        //    print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
        //    Debug.DrawRay(contact.point, contact.normal, Color.cyan);
        //    Debug.Log(contact.point);
        //}
    }
	//void Start ()
    void Update()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        /*int i = 0;
      //  int[] vetexCount = vetexCount[i].Length = mesh.vertices.Length;
        foreach(ContactPoint vert in mesh)
        {
            vert4[i] = mesh.vertices.Length;
        } */
        //vert4 = new List<meshConstructor>(capacity : vertices.Length);
        if(bootCall)
        {
            int i = 0;
            // vert4.Capacity = vertices.Length;
            while (i < vertices.Length)
            {
                vert4.Add(new meshConstructor(mesh.vertices[i].x, mesh.vertices[i].y, mesh.vertices[i].z, i));
                i++;
                if (i == 0)
                { break; }
            }
            Debug.Log(vert4.Capacity);
            ///<MESSAGE This is where the constructor determins each and every vert4 location. vert4 been the plane.mesh vert count and modifying locations.
            /// Once infomation is recorded, you can then utilise those numbers to identify the nearest contact points and manipulate their location, or link their locations
            /// to points on another object that will manipulate the surface. FYI, dirt and dig of a grave to manipulate and lower the earth.

            bootCall = false;
        } //end point
    }
	
	// Update is called once per frame
	//void Update ()
 //   {
 //       if(complicatedBuild)
 //       {
 //           Mesh mesh = GetComponent<MeshFilter>().mesh;
 //           Vector3[] vertices = mesh.vertices;
 //          // vert4.Add(20.0f, 20.0f, 20.0f);



 //       }

 //       if(standardTest /*&& count < time*/){
 //           Mesh mesh = GetComponent<MeshFilter>().mesh;
 //           Vector3[] vertices = mesh.vertices;
 //           int i = 0;
 //           bool a = false;
 //           bool b = false;
 //           bool c = false;
 //           bool d = true;
 //           if (requestPull)
 //           {
 //               while (i < vertices.Length)
 //               {
 //                   //if
 //                   if (a)
 //                   { vertices[i].y += movement + movement + 0.09f; a = false; d = true; }
 //                   else if (b)
 //                   { vertices[i].y += movement - movement + 0.04f; b = false; a = true; }
 //                   else if (c)
 //                   { vertices[i].y += movement + movement - 0.05f; c = false; b = true; }
 //                   else if (d)
 //                   { vertices[i].y += movement + movement; /** Time.deltaTime*/ d = false; c = true; }
 //                   //vertices[i].y = movement * Time.deltaTime;
 //                   i++;
 //               }
 //               //requestPull = false;
 //           }

 //           if(count >= time)
 //           {
 //               if(switche)
 //               {
 //                   switche = false;
 //                   count = 0;
 //                   movement = 0 - movement; 
 //               }
 //               if(!switche)
 //               {
 //                   switche = true;
 //                   count = 0;
 //                   movement = 0 + movement;
 //               }
 //           }
 //           else { count = count + (1 * Time.deltaTime);}
 //           mesh.vertices = vertices;
 //           mesh.RecalculateBounds();
 //       }

 //   }
}
