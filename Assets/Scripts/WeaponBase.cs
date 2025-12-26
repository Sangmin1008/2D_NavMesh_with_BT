using System;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    [SerializeField] protected GameObject projectilePrefab;
    [SerializeField] protected Transform projectileSpawnPoint;
    
    protected Transform _target;
    protected float _damage;
    private float _maxCooldownTime;
    private float _currentCooldownTime = 0f;
    private bool _isSkillAvailable = true;

    public void Setup(Transform target, float damage, float cooldownTime)
    {
        _target = target;
        _damage = damage;
        _maxCooldownTime = cooldownTime;
    }

    private void Update()
    {
        if (_isSkillAvailable == false && Time.time - _currentCooldownTime > _maxCooldownTime)
        {
            _isSkillAvailable = true;
        }
    }

    public void TryAttack()
    {
        if (_isSkillAvailable)
        {
            OnAttack();
            _isSkillAvailable = false;
            _currentCooldownTime = Time.time;
        }
    }

    public abstract void OnAttack();
}
