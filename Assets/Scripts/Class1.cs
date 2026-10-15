// IDamageable.cs
public interface IDamageable
{
    void TakeDamage(int amount);
}

// Entity.cs
using UnityEngine;
public abstract class Entity : MonoBehaviour, IDamageable
{
    [SerializeField] protected int health = 3;
    [SerializeField] protected float speed = 2f;

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0) Die();
    }
    protected abstract void Move();
    protected virtual void Die() { Destroy(gameObject); }
    protected virtual void Update() { Move(); }
}

// Player.cs
using UnityEngine;
public class Player : Entity
{
    [SerializeField] private Weapon currentWeapon;
    protected override void Move() { /* TODO: WASD */ }
    protected override void Die() { /* TODO: game over */ base.Die(); }
}

// Enemy.cs
using UnityEngine;
public abstract class Enemy : Entity
{
    [SerializeField] protected int scoreValue = 10;
    protected override void Die() { /* TODO: sumar puntos */ base.Die(); }
}

// Chaser.cs
public class Chaser : Enemy { protected override void Move() { /* TODO: perseguir */ } }

// Zigzag.cs
public class Zigzag : Enemy { protected override void Move() { /* TODO: onda senoidal */ } }

// Shooter.cs
public class Shooter : Enemy { protected override void Move() { /* TODO */ } }

// Weapon.cs
using UnityEngine;
public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected int damage = 1;
    [SerializeField] protected float fireRate = 0.3f;
    [SerializeField] protected Bullet bulletPrefab;
    public abstract void Fire(Vector2 direction);
}

// Pistol.cs
using UnityEngine;
public class Pistol : Weapon { public override void Fire(Vector2 direction) { /* TODO */ } }

// Shotgun.cs
using UnityEngine;
public class Shotgun : Weapon { public override void Fire(Vector2 direction) { /* TODO */ } }

// Bullet.cs
using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private int damage = 1;
    // TODO: moverse y llamar TakeDamage en OnTriggerEnter2D
}

// GameManager.cs
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int Score { get; private set; }
    void Awake() { Instance = this; }
    public void AddScore(int points) { Score += points; }
}

// EnemySpawner.cs
using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy[] enemyPrefabs;
    // TODO: instanciar enemigos cada pocos segundos
}