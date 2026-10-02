using UnityEngine;

public class MoveByVelocityMoveByVelocity : MonoBehaviour
{
	private float speed = 3f;
	Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(speed, 0f);
    }
}
