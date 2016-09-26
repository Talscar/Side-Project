using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class MoveToNewIntersection : MonoBehaviour
{
    private NavMeshAgent m_agent;
    public GameObject markerContainer;
    private List<Transform> m_markers;
    // Use this for initialization
    void Start()
    {
        m_agent = GetComponent<NavMeshAgent>();
        var markers = markerContainer.GetComponentsInChildren<Transform>();
        m_markers = markers.ToList();
        m_markers.RemoveAt(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(m_agent.remainingDistance < 1)
        {
            m_agent.destination = m_markers[Random.Range(0, m_markers.Count)].position;
        }
     
    }
}
