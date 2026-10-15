using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity
{
    [SerializeField]private Rigidbody2D rb;
    public Weapon currentWeapon;

    public override void Move()
    {
        Vector2 input = Vector2.zero;

        if (Keyboard.current != null)
        {
            if (Keyboard.current.wKey.isPressed) input.y += 1;
            if (Keyboard.current.sKey.isPressed) input.y -= 1;
            if (Keyboard.current.aKey.isPressed) input.x -= 1;
            if (Keyboard.current.dKey.isPressed) input.x += 1;
        }

        transform.Translate(input.normalized * (speed * Time.deltaTime));
    }

    public override void Die()
    {
        // TODO: Implement game over logic
        base.Die();
    }
}
