using UnityEngine;
public class Normal : Weapon
{
    public override void Fire()
    {
        Bullet bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
