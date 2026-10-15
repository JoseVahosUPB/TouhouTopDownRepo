using UnityEngine;

public abstract class Entity : MonoBehaviour, IDamageable
{
    [SerializeField] protected int health;
    [SerializeField] protected int speed;

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0) Die();
    }
    public abstract void Move();
    public virtual void Die() { Destroy(gameObject); }
    protected virtual void Update() { Move(); }
}
