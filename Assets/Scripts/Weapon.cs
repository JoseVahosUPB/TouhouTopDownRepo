using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected int damage;
    [SerializeField] protected float fireRate;
    [SerializeField] protected Bullet bulletPrefab;
    public abstract void Fire();
}
