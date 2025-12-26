using System;
using System.Linq;
using Unity.Behavior;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFSM : MonoBehaviour
{
    private Transform _target;
    private NavMeshAgent _navMeshAgent;
    private BehaviorGraphAgent _behaviorAgent;

    // private void Update()
    // {
    //     _navMeshAgent.SetDestination(_target.position);
    // }

    public void Setup(Transform target, GameObject[] wayPoints)
    {
        _target = target;
        
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _behaviorAgent = GetComponent<BehaviorGraphAgent>();
        
        _navMeshAgent.updateRotation = false;
        _navMeshAgent.updateUpAxis = false;
        _behaviorAgent.SetVariableValue("PatrolPoints", wayPoints.ToList());
        _behaviorAgent.SetVariableValue("Target", target.gameObject);
    }
}
