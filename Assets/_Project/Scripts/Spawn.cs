using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;
    [SerializeField] private float spawnInterval = 1f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval) {
            timer = 0f;
            GameObject newObject = pool.GetObject(transform.position);
            newObject.GetComponent<TimedObject>().SetPool(pool);
        }
    }
}