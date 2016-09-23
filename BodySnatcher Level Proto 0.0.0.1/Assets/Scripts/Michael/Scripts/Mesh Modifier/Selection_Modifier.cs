using UnityEngine;
using System.Collections;

public class Selection_Modifier : MonoBehaviour {

    meshConstructor mCon;
    Constructor_VertContactGrouping vCon; //adds infomation
    unityScript_meshVert mVert;

    public GameObject mModifier;
    public int vCon_pmIdentity = 0;

	// Use this for initialization
	void Start () {

        /**
        if(mVert.vert4[vCon_pmIdentity].counter != vCon_pmIdentity)
        { Debug.LogError("Invalid verticy 4 of vCon_pmIdentity: " + vCon_pmIdentity + ", Cannot be found; "); }

        int i = 0;
        while(i < mVert.vert4.Count)
        {


            i++;
        } 
        **/
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
