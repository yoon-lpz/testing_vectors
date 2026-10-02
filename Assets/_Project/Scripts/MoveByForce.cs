using UnityEngine;

public class MoveByForce : MonoBehaviour
{
	private float force = 3f;
	private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.AddForce(new Vector2(force, 0f));
    }
}
