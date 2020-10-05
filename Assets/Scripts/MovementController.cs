using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float xMovementSpeed = 0.25f;
    public float yMovementSpeed = 0.2f;
    public int lives = 1;
    private Rigidbody2D body2D;

    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("left"))
        {
            body2D.velocity = Vector2.ClampMagnitude(body2D.velocity + (new Vector2(-10f, 0.0f) * xMovementSpeed), 10f);
        }

        if (Input.GetKey("right"))
        {
            body2D.velocity = Vector2.ClampMagnitude(body2D.velocity + (new Vector2(10f, 0.0f) * xMovementSpeed), 10f);
        }

        if (Input.GetKey("up"))
        {
            body2D.velocity = Vector2.ClampMagnitude(body2D.velocity + (new Vector2(0f, 10.0f) * yMovementSpeed), 10f);
        }

        if (Input.GetKey("down"))
        {
            body2D.velocity = Vector2.ClampMagnitude(body2D.velocity + (new Vector2(0f, -10.0f) * yMovementSpeed), 10f);
        }
    }
}