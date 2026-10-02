using UnityEngine;

public class EnemyVision : MonoBehaviour
{
	[SerializeField] LayerMask groundLayer;
	public float visionRange = 6f, rayLength = 0.6f;
    public Transform player;
	private SpriteRenderer spriteRenderer;

	void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 direction = (player.position - transform.position).normalized;
		RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, rayLength);
		Debug.DrawRay(transform.position, direction * visionRange, Color.yellow);

		if (hit.collider != null && hit.collider.CompareTag("Player")) spriteRenderer.color = Color.red;
		else spriteRenderer.color = Color.white;
	}
}
