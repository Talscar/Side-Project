using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class MoveToNewIntersection : MonoBehaviour
{
    public Transform Player;
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
        Debug.DrawLine(m_agent.GetComponent<Transform>().position, m_agent.destination);
        if (m_agent.remainingDistance < 1)
        {
            float distanceFromPlayer = Vector3.Distance(Player.position, transform.position);
            Vector3 closest = new Vector3(Mathf.Infinity, Mathf.Infinity, Mathf.Infinity);
            foreach (var marker in m_markers)
            {
                if (Vector3.Distance(marker.position, m_agent.destination) > 1)
                {
                    if (Vector3.Distance(marker.position, m_agent.destination) < Vector3.Distance(m_agent.destination, closest))
                    {             
                        RaycastHit hit;
                        Physics.Linecast(m_agent.destination, marker.position, out hit);       
                        if (hit.collider == null)
                        {
                            closest = marker.position;
                        }                        
                    }
                }
            }
            m_agent.destination = closest;
        }

    }
}
