using UnityEngine;

public class Chaser : Enemy {
    public override void Move()
    {
        // Find the player and move towards them
        Player player = FindAnyObjectByType<Player>();
        if (player == null) return;

        Vector2 direction = (player.transform.position - transform.position).normalized;
        transform.Translate(direction * (speed * Time.deltaTime));
    }
}
