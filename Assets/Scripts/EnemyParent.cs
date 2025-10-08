using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    [SerializeField] private Transform startMarker;
    [SerializeField] private Transform endMarker;
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private int health = 3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected void Walk()
    {
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, Mathf.PingPong(Time.time * speed, 1f));
    }

    protected void DamageTaken(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
