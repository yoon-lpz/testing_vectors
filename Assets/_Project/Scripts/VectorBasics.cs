using UnityEngine;

public class VectorBasics : MonoBehaviour
{
    public Vector2 startPosition = new Vector2(2,1);
    public Vector2 myVector = new Vector2(3, 4);
    void Start()
    {
        startPosition = transform.position;
        Debug.Log($"myVector.magnitude: {myVector.magnitude}");
        Debug.Log($"myVector.normalized: {myVector.normalized}");
    }
}
