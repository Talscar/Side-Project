using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class m_VertModifier : MonoBehaviour {
    public GameObject mesh_ToModify;

    public int index_Id = 0;
    public int mod_Location = 0;
    int locate = 0;

    Vector3 obj_Position;    
    void Update()
    {
        locate = index_Id + mod_Location;

        Debug.DrawRay(gameObject.transform.position, mesh_ToModify.GetComponent<m_VertCount>().vertices[locate], Color.magenta);
        Debug.DrawRay(mesh_ToModify.GetComponent<m_VertCount>().vertices[locate], gameObject.transform.position, Color.magenta);

        Debug.DrawRay(mesh_ToModify.GetComponent<m_VertCount>().vertices[locate] , gameObject.transform.position - new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z), Color.red);

///<example        Debug.DrawRay(vertices[LocateAndControlRayTestTemp], new_Object.transform.position, Color.blue); //unknown
///                Debug.DrawRay(new_Object.transform.position, vertices[LocateAndControlRayTestTemp], Color.red);
/// ></example>
/// 

        if(gameObject.transform.position != obj_Position)
        {
            mesh_ToModify.GetComponent<m_VertCount>().vertices[locate] = gameObject.transform.position;

            Debug.LogWarning("Pos of Vert line 85: " + mesh_ToModify.GetComponent<m_VertCount>().vertices[locate] + ", Compare to other object: " + mesh_ToModify.GetComponent<m_VertCount>().gameObject.transform.position);

            //vert4[LocateAndControlRayTestTemp] = vert4(v);
            mesh_ToModify.GetComponent<m_VertCount>().mesh.vertices = mesh_ToModify.GetComponent<m_VertCount>().vertices;

            mesh_ToModify.GetComponent<m_VertCount>().mesh.RecalculateBounds();
            obj_Position = gameObject.transform.position;
        }
        else { obj_Position = gameObject.transform.position; }
    }
    
}
