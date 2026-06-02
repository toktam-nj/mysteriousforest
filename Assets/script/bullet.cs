using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        enemyhealth enemy = other.GetComponent<enemyhealth>();

        if (enemy != null)
        {
            enemy.TakeDamage();
        }

        Destroy(gameObject);
    }
}
