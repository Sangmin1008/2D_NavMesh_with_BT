using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    private MovementRigidbody2D _movement;
    private Transform _target;
    private float _damage;

    public void Setup(Transform target, float damage)
    {
        _movement = GetComponent<MovementRigidbody2D>();
        _target = target;
        _damage = damage;
        
        _movement.MoveTo((target.position - transform.position).normalized);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // collision.GetComponent<Player>().TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
