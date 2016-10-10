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
        Debug.Log("mkay");


        Debug.DrawLine(m_agent.GetComponent<Transform>().position, m_agent.destination);
        if (m_agent.remainingDistance < 1)
        {
            Vector3 closest = new Vector3();
            float closestDistance = Mathf.Infinity;
            foreach (var marker in m_markers)
            {
                if (Vector3.Distance(marker.position, m_agent.destination) > 1)
                {
                    float weightedDistance;
                    float distanceFromPlayer = Vector3.Distance(Player.position, marker.transform.position);
                    weightedDistance = Vector3.Distance(transform.position, marker.position) + distanceFromPlayer;
                    //Debug.DrawLine(transform.position, marker.position, Color.blue, 2);
                    if (weightedDistance < closestDistance)
                    {
                        RaycastHit hit;
                        Debug.DrawLine(transform.position, marker.position, Color.blue, 2);
                        Physics.Linecast(transform.position, marker.position, out hit);
                        //Debug.DrawLine(transform.position, hit.point, Color.red, 2);
                        if (hit.collider == null || hit.collider.tag != "wall")
                        {
                            closest = marker.position;
                            closestDistance = weightedDistance;
                        }
                    }
                }
            }
            m_agent.destination = closest;
        }

    }
}
