using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int damage;

    private Vector2 direction = Vector2.up;

    private void Update()
    {
        // Move the bullet in its set direction
        transform.Translate(direction * (speed * Time.deltaTime));
    }

    public void Initialize(Vector2 dir, int damageAmount)
    {
        direction = dir.normalized;
        damage = damageAmount;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the other object can take damage, apply it
        IDamageable d = other.GetComponent<IDamageable>();
        if (d != null)
        {
            d.TakeDamage(damage);
        }

        // Destroy the bullet on any collision
        Destroy(gameObject);
    }
}
