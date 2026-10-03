using UnityEngine;
using Vector3 = UnityEngine.Vector3;


public class Bullet : MonoBehaviour
{
    
    public Vector3 direction;
    public float speed;
    public float damage;
    public bool pierce;

    void Start()
    {
        gameObject.transform.rotation = Quaternion.LookRotation(direction);
    }
    void Update()
    {
        gameObject.transform.position += direction * damage;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Entity>() != null)
        {
            collision.gameObject.GetComponent<Entity>().TakeDamage(damage);
            if (pierce)
            {
                Destroy(gameObject);
            }
        }

        
    }
}
