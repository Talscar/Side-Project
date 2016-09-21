using UnityEngine;
using System.Collections;

public class graveModifier : MonoBehaviour {

    public float maxTravel = 0.7f;


    public GameObject terrain;
    private Mesh levelMesh;
    Vector3[] vetexModifier;



    void Start()
    {
        // We assign the variable DaMesh of type Mesh to the variable mesh of the Component MeshFilter 
        levelMesh = terrain.GetComponent<MeshFilter>().mesh;
        // We 
        vetexModifier = new Vector3[levelMesh.vertexCount];
    }
    // Update is called once per frame
    void OnCollisionStay(Collision collider)
    {
        Debug.Log("Vetex count: " + vetexModifier.Length);

        int i = 0;
        foreach (ContactPoint vert in collider)
        {
            Debug.Log("Info vert: " + vert + ", Point* " + vert.point + ", normal* " + vert.normal + ", position: " + vert.thisCollider);
            vetexModifier[i] = vetexModifier[i] - new Vector3(-1, -1, -1)/*gameObject.transform.position*/;

            levelMesh.vertices[i] = vetexModifier[i];
            ///levelMesh.vertices[i] += new Vector3(levelMesh.vertices[i].x, (vetexModifier[i].y * Time.deltaTime), levelMesh.vertices[i].z);
            Debug.Log("Value: " + i + " ~ " + vetexModifier + " *(" + vert + ")* ");
            Debug.Log("Modification CHECK!");
            levelMesh.RecalculateBounds();

        }
        ////////////////int i = 57;

        ////////////////Debug.Log("Value: " + i + " ~ " + vetexModifier[0] + " *(" + vetexModifier[1] + ")* " + vetexModifier[2]);
        ////////////////vetexModifier[i] = vetexModifier[i] - new Vector3(0, 5, 0)/*gameObject.transform.position*/;

        ////////////////levelMesh.vertices = vetexModifier;
        ////////////////Debug.Log("Value: " + i + " ~ " + vetexModifier[0] + " *(" + vetexModifier[1] + ")* " + vetexModifier[2]);
        ////////////////Debug.Log("Modification CHECK!"); 
        //foreach (ContactPoint vert in collider)
        //{
        //    vetexModifier[i] = vetexModifier[i] - new Vector3(-1, -1, -1)/*gameObject.transform.position*/;

        //    levelMesh.vertices = vetexModifier;
        //    Debug.Log("Value: " + i + " ~ " + vetexModifier + " *(" + vert + ")* ");
        //    Debug.Log("Modification CHECK!");    
        //}

    }

    void Update ()
    {

        levelMesh.RecalculateBounds();

    }
}
