using UnityEngine;

public class RingMovement : MonoBehaviour
{
    public float speed = 2f;
    public float range = 3f;
    private float startX;
    private int direction = 1;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        transform.position += Vector3.right * direction * speed * Time.deltaTime;

        if (Mathf.Abs(transform.position.x - startX) > range)
        {
            direction *= -1;
        }
    }
}
