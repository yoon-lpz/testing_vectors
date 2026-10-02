using System.Net.NetworkInformation;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementRaycast : MonoBehaviour
{
	private Rigidbody2D rb;
	float speed = 5f, jumpForce = 7f, rayLength = 0.6f;
	[SerializeField] string nextScene = "";
	[SerializeField] LayerMask groundLayer;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();

	}

	void Update()
	{
		float horizontal = Input.GetAxisRaw("Horizontal");
		rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);

		if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
		Debug.DrawRay(transform.position, Vector2.down * rayLength, Color.red);
	}

	public bool IsGrounded() {
		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, rayLength, groundLayer);

		if (hit.collider != null) Debug.Log(hit.collider.gameObject.name);

		return hit;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.CompareTag("Coin")) { 
			GameManager.AddCoin(1);
			if (GameManager.coins == GameManager.totalCoins) GameManager.LoadScreen(nextScene);

		}

		Destroy(collision.gameObject);
    }
}
