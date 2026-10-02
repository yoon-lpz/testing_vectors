using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class MoveByPosition : MonoBehaviour
{
	private float speed = 3f;

    void Update()
    {
		transform.position += Vector3.right * speed * Time.deltaTime;
	}
}
