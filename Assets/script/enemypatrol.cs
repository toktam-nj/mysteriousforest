using UnityEngine;

public class enemypatrol : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 5f;

    private Vector3 startPosition;
    private int direction = 1;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * direction * Time.deltaTime);

        float movedDistance = Vector3.Distance(startPosition, transform.position);

        if (movedDistance >= distance)
        {
            direction = direction * -1;
            transform.Rotate(0, 180, 0);
        }
    }
}
