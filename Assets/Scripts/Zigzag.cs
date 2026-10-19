using UnityEngine;

public class Zigzag : Enemy
{
    [SerializeField] private float amplitude = 1f;
    [SerializeField] private float frequency = 2f;
    private float initialY;
    private float phase;

    private void Start()
    {
        initialY = transform.position.y;
        phase = Random.Range(0f, Mathf.PI * 2f);
    }

    public override void Move()
    {
        // Move horizontally (to the left) while oscillating on the Y axis using a sine wave
        float newX = transform.position.x - (speed * Time.deltaTime * transform.localScale.x);
        float newY = initialY + Mathf.Sin(Time.time * frequency + phase) * amplitude;
        transform.position = new Vector2(newX, newY);
    }
}
