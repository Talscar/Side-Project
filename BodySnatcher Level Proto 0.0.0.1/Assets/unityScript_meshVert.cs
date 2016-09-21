using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class unityScript_meshVert : MonoBehaviour {
    public bool requestPull = true;
    public bool standardTest = false;
    public bool complicatedBuild = true;

    public float time = 15f;
    float count = 0.0f;
    bool switche = true;

    public float movement = 50.0f;

    

	void Start ()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        /*int i = 0;
      //  int[] vetexCount = vetexCount[i].Length = mesh.vertices.Length;
        foreach(ContactPoint vert in mesh)
        {
            vert4[i] = mesh.vertices.Length;
        } */
        {
                int i = 0;
                while(i < vertices.Length)
                {

                if(i == 0)
                { break; }
                }
            } //end point
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(complicatedBuild)
        {
            Mesh mesh = GetComponent<MeshFilter>().mesh;
            Vector3[] vertices = mesh.vertices;



        }

        if(standardTest /*&& count < time*/){
            Mesh mesh = GetComponent<MeshFilter>().mesh;
            Vector3[] vertices = mesh.vertices;
            int i = 0;
            bool a = false;
            bool b = false;
            bool c = false;
            bool d = true;
            if (requestPull)
            {
                while (i < vertices.Length)
                {
                    //if
                    if (a)
                    { vertices[i].y += movement + movement + 0.09f; a = false; d = true; }
                    else if (b)
                    { vertices[i].y += movement - movement + 0.04f; b = false; a = true; }
                    else if (c)
                    { vertices[i].y += movement + movement - 0.05f; c = false; b = true; }
                    else if (d)
                    { vertices[i].y += movement + movement; /** Time.deltaTime*/ d = false; c = true; }
                    //vertices[i].y = movement * Time.deltaTime;
                    i++;
                }
                //requestPull = false;
            }

            if(count >= time)
            {
                if(switche)
                {
                    switche = false;
                    count = 0;
                    movement = 0 - movement; 
                }
                if(!switche)
                {
                    switche = true;
                    count = 0;
                    movement = 0 + movement;
                }
            }
            else { count = count + (1 * Time.deltaTime);}
            mesh.vertices = vertices;
            mesh.RecalculateBounds();
        }

    }
}
