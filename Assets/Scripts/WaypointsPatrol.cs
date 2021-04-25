using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointsPatrol : MonoBehaviour
{
    public NavMeshAgent nawMeshAgent;
    public Transform[] waypoints;
    public Enemy enemy;

    int currentWaypointIndex;

    private void Start()
    {
        nawMeshAgent.SetDestination(waypoints[0].position);
        enemy = GetComponent<Enemy>();
    }

    private void Update()
    {
        if (!enemy.IsDead && nawMeshAgent.remainingDistance <= nawMeshAgent.stoppingDistance)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            nawMeshAgent.SetDestination(waypoints[currentWaypointIndex].position);
        }

    }
}
