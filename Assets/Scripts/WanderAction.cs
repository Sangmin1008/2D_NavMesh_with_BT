using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;
using UnityEngine.AI;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Wander", story: "[Self] Navigate To WanderPosition", category: "Action", id: "b7d72c6a0f75d2627d0b1cd520272faf")]
public partial class WanderAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Self;

    private NavMeshAgent _agent;
    private Vector3 _wanderPosition;
    private float _currentWanderTime = 0f;
    private float _maxWanderTime = 5f;

    protected override Status OnStart()
    {
        int jitterMin = 0;
        int jitterMax = 360;
        float wanderRadius = UnityEngine.Random.Range(2.5f, 6f);
        int wanderJitter = UnityEngine.Random.Range(jitterMin, jitterMax);
        
        _wanderPosition = Self.Value.transform.position + Utils.GetPositionFromAngle(wanderRadius, wanderJitter);
        _agent = Self.Value.GetComponent<NavMeshAgent>();
        _agent.SetDestination(_wanderPosition);
        _currentWanderTime = Time.time;
        
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        if ((_wanderPosition - Self.Value.transform.position).sqrMagnitude < 0.1f ||
            Time.time - _currentWanderTime > _maxWanderTime)
        {
            return Status.Success;
        }
        
        return Status.Running;
    }

    protected override void OnEnd()
    {
    }
}

