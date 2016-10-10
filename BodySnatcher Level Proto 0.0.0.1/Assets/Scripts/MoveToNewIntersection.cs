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
    float calculatePathLength(Vector3 startPos, Vector3 endPos)
    {
        NavMeshPath path = new NavMeshPath();
        NavMesh.CalculatePath(startPos,endPos, NavMesh.AllAreas, path);
        if (path.corners.Length < 2)
        {
            return 0;
        }
        Vector3 previousCorner = path.corners[0];
        float lengthSoFar = .0f;
        for (int i = 1; i < path.corners.Length; i++)
        {
            Vector3 currentCorner = path.corners[i];
            lengthSoFar += Vector3.Distance(previousCorner, currentCorner);
            previousCorner = currentCorner;
        }
        return lengthSoFar;
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
                    float calculatedPathLength = calculatePathLength(transform.position, marker.position);       
                    float distanceFromPlayer = calculatePathLength(marker.position, Player.position);
                    float weightedDistance = calculatedPathLength + distanceFromPlayer;
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
