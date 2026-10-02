using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyData data;
    public EnemyData[] enemyTypes;
    public int currentHealth;

    private void Start()
    {
        data = GetEnemyData();
        currentHealth = data.maxHealth;
        GetComponent<SpriteRenderer>().color = data.color;
	}

    private void Update()
    {
        transform.Translate(Vector2.left * data.speed * Time.deltaTime);
		if (Input.GetKeyDown(KeyCode.Z)) TakeDamage(1);
	}

	public void TakeDamage(int amount) {
        currentHealth -= amount;
        if (currentHealth <= 0) Destroy(gameObject);
    }

    private EnemyData GetEnemyData() => enemyTypes[Random.Range(0, enemyTypes.Length)];
}
