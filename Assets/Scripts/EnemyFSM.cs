using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFSM : MonoBehaviour
{
    private Transform _target;
    private NavMeshAgent _navMeshAgent;

    private void Update()
    {
        _navMeshAgent.SetDestination(_target.position);
    }

    public void Setup(Transform target)
    {
        _target = target;
        
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.updateRotation = false;
        _navMeshAgent.updateUpAxis = false;
    }
}
