using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class m_VertCount : MonoBehaviour {

    //public List<meshConstructor> vert4 = new List<meshConstructor>();
    //public List<Constructor_VertContactGrouping> points = new List<Constructor_VertContactGrouping>();
    //Mesh mesh;
    //// Use this for initialization
    //void Start () {
    //    mesh = GetComponent<MeshFilter>().mesh;
    //    Vector3[] vertices = mesh.vertices;


    //    {
    //        int i = 0;
    //        while (i < vertices.Length)
    //        {
    //            vert4.Add(new meshConstructor(mesh.vertices[i].x, mesh.vertices[i].y, mesh.vertices[i].z, i));


    //            Debug.Log("vert4 (x, y, z, id): (" + vert4[i].vert4_x + ", " + vert4[i].vert4_y + ", " + vert4[i].vert4_z + ", " + vert4[i].counter + ");" );
    //            i++;
    //        }
    //        Debug.Log(vert4.Capacity);

    //    } 
    //}
    public bool MeshModifierLoop = false;


    public List<meshConstructor> vert4 = new List<meshConstructor>();
    public List<Constructor_VertContactGrouping> points = new List<Constructor_VertContactGrouping>();
    Mesh mesh;
    public int LocateAndControlRayTestTemp = 5;
    Vector3[] vertices;

    public GameObject new_Object;
    // Use this for initialization
    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        vertices = mesh.vertices;


        {
            int i = 0;
            Debug.Log(vert4.Count);
            while (i < vertices.Length)
            {
                vert4.Add(new meshConstructor(vertices[i].x, vertices[i].y, vertices[i].z, i));
                //Debug.Log(vert4.Count + " *THEN* i count??? " + i);
                //vertices[i] += Vector3.up * Time.deltaTime;
                //vertices[i] += Vector3.up * Time.deltaTime;
                //mesh.vertices[i] += 3 * Time.deltaTime;
                i++;
            }
            //mesh.vertices = vertices;
            //mesh.RecalculateBounds();


           // Debug.Log(vert4.Count);
            //Debug.Log(vert4.Capacity);
            int ii = 0;
            foreach (meshConstructor vetex in vert4)
            {
             //   Debug.Log(vetex.counter);

                ii++;
               // Debug.Log(vert4.Count + " *THEN* i count??? " + i);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

        if(MeshModifierLoop)
        {
            vertices[LocateAndControlRayTestTemp] = new_Object.transform.position;

            //vert4[LocateAndControlRayTestTemp] = vert4(v);
            mesh.vertices = vertices;
            mesh.RecalculateBounds();
        }

        Debug.DrawRay(new Vector3(vert4[LocateAndControlRayTestTemp].vert4_x, vert4[LocateAndControlRayTestTemp].vert4_y, vert4[LocateAndControlRayTestTemp].vert4_z), new_Object.transform.position, Color.green);

        

    }
}
