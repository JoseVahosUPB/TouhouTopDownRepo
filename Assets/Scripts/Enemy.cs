using UnityEngine;

public abstract class Enemy : Entity
{
    [SerializeField] private int damage;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the other object is the player, apply damage
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamage(damage);

            // Destroy the enemy on the first collision with the player
            Destroy(gameObject);
        }

    }
}