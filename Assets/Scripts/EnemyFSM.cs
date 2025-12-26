using System;
using System.Linq;
using Unity.Behavior;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFSM : MonoBehaviour
{
    [SerializeField] private float cooldownTime = 2f;
    [SerializeField] private float damage = 10f;
    
    private Transform _target;
    private NavMeshAgent _navMeshAgent;
    private BehaviorGraphAgent _behaviorAgent;
    private WeaponBase _currentWeapon;

    // private void Update()
    // {
    //     _navMeshAgent.SetDestination(_target.position);
    // }

    public void Setup(Transform target, GameObject[] wayPoints)
    {
        _target = target;
        
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _behaviorAgent = GetComponent<BehaviorGraphAgent>();
        _currentWeapon = GetComponent<WeaponBase>();
        
        _navMeshAgent.updateRotation = false;
        _navMeshAgent.updateUpAxis = false;
        _behaviorAgent.SetVariableValue("PatrolPoints", wayPoints.ToList());
        _behaviorAgent.SetVariableValue("Target", target.gameObject);
        
        _currentWeapon.Setup(_target, damage, cooldownTime);
    }
}
