using UnityEngine;
public class Normal : Weapon
{
    // Track last time we fired to respect fireRate (shots per second)
    private float lastFireTime = -Mathf.Infinity;

    public override void Fire()
    {
        // If fireRate is positive, compute minimum interval between shots
        if (fireRate > 0f)
        {
            float interval = 1f / fireRate;
            if (Time.time - lastFireTime < interval) return; // still cooling down
            lastFireTime = Time.time;
        }

        // Instantiate bullet and set its direction based on the weapon's up vector
        Bullet bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        if (bullet != null)
        {
            Vector2 dir = transform.up;
            bullet.Initialize(dir, damage);
        }
    }
}
