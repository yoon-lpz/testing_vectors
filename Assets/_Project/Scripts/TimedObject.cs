using UnityEngine;

public class TimedObject : MonoBehaviour
{
    [SerializeField] private float lifeTime = 3f;

    private ObjectPool pool;
    private float timer;

    public void SetPool(ObjectPool newPool) {
        pool = newPool;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifeTime) {
			pool.ReturnObject(gameObject);
            timer = 0;
		}
        
    }
}
