using UnityEngine;

public class SmartTurret : MonoBehaviour
{
	public float visionRange = 6f, timeBetweenShots = 2f, timer = 0, speed = 3f;
	public GameObject bulletPrefeb;
	public Transform player;
	private SpriteRenderer spriteRenderer;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void Update()
	{
		if (IsSeeingPlayer()) {
			timer += Time.deltaTime;
			Vector2 direction = player.position - transform.position;
			float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
			transform.eulerAngles = new Vector3(0, 0, angle);
			if (timer >= timeBetweenShots) {
				Shot(direction);
				timer -= timeBetweenShots;
			}
		}
	}

	bool IsSeeingPlayer() {
		Vector2 direction = (player.position - transform.position).normalized;
		RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, visionRange);
		return hit;
	}
	void Shot(Vector2 direction) {
		GameObject bullet = Instantiate(bulletPrefeb, transform.position, Quaternion.identity);
		Rigidbody2D bulletrb = bullet.GetComponent<Rigidbody2D>();
		bulletrb.linearVelocity = direction * speed;
		Destroy(bullet, 3f);
	}
}
