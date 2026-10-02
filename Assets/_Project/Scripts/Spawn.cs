using UnityEngine;

public class Spawn : MonoBehaviour
{
    public ObjectPool pool;

    private void Start()
    {
        pool = GetComponent<ObjectPool>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) pool.GetObject(transform.position);
    }
}