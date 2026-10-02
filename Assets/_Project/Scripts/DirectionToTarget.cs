using UnityEngine;

public class DirectionToTarget : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        Vector2 direction = target.position - transform.position;
        Debug.DrawLine(target.position, transform.position, Color.coral);
    }
}
