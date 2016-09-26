using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class m_VertModifier : MonoBehaviour {
    public bool UsingVertMaxHight = true;
    Vector3[] MaxHight;

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

        if (UsingVertMaxHight == true)
        { MaxHight[locate] = mesh_ToModify.GetComponent<m_VertCount>().vertices[locate]; } //null refrence exception;*
        if(gameObject.transform.position != obj_Position)
        {
            mesh_ToModify.GetComponent<m_VertCount>().vertices[locate] = gameObject.transform.position;

            Debug.LogWarning("Pos of Vert line 85: " + mesh_ToModify.GetComponent<m_VertCount>().vertices[locate] + ", Compare to other object: " + mesh_ToModify.GetComponent<m_VertCount>().gameObject.transform.position);

            if(UsingVertMaxHight == true && mesh_ToModify.GetComponent<m_VertCount>().vertices[locate].y > MaxHight[locate].y)
            {
                mesh_ToModify.GetComponent<m_VertCount>().vertices[locate] = MaxHight[locate];
            }

            //vert4[LocateAndControlRayTestTemp] = vert4(v);
            mesh_ToModify.GetComponent<m_VertCount>().mesh.vertices = mesh_ToModify.GetComponent<m_VertCount>().vertices;
            mesh_ToModify.GetComponent<m_VertCount>().mesh.RecalculateBounds();
            mesh_ToModify.GetComponent<m_VertCount>().mesh.RecalculateNormals();
            mesh_ToModify.GetComponent<m_VertCount>().mesh.Optimize();
            obj_Position = gameObject.transform.position;
        }
        else { obj_Position = gameObject.transform.position; }
    }
    
}
