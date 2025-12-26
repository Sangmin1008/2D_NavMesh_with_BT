using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Weapon", story: "Tru attack with [CurrentWeapon]", category: "Action", id: "f31d7f9e08d548eac05ccf1688607233")]
public partial class WeaponAction : Action
{
    [SerializeReference] public BlackboardVariable<WeaponBase> CurrentWeapon;
    

    protected override Status OnUpdate()
    {
        CurrentWeapon.Value.TryAttack();
        
        return Status.Success;
    }

}

