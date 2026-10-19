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
            if (Keyboard.current.upArrowKey.isPressed) input.y += 1;
            if (Keyboard.current.downArrowKey.isPressed) input.y -= 1;
            if (Keyboard.current.leftArrowKey.isPressed) input.x -= 1;
            if (Keyboard.current.rightArrowKey.isPressed) input.x += 1;
        }

        transform.Translate(input.normalized * (speed * Time.deltaTime));
    }

    public override void Die()
    {
        // Simple game-over handling: log and then perform default destruction
        Debug.Log("Game Over");
        base.Die();
    }
}
