using UnityEngine;

public class MovementController2 : MonoBehaviour
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
        if (Input.GetKey("a"))
        {
            body2D.velocity = new Vector3(-10f, 0.0f, 0.0f) * xMovementSpeed;
        }

        if (Input.GetKey("d"))
        {
            body2D.velocity = new Vector3(10f, 0.0f, 0.0f) * xMovementSpeed;
        }

        if (Input.GetKey("w"))
        {
            body2D.velocity = new Vector3(0.0f, 10f, 0.0f) * yMovementSpeed;
        }

        if (Input.GetKey("s"))
        {
            body2D.velocity = new Vector3(0.0f, -10f, 0.0f) * yMovementSpeed;
        }
    }
}
