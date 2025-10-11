using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {

    }
    
    void OnCollisionEnter(Collision collision)
    {
        SystemeDeSante health = collision.gameObject.GetComponent<SystemeDeSante>();

        if (health != null && !collision.gameObject.CompareTag("Player"))
        {
            health.TakeDamage(10f);
            Destroy(gameObject);
        }
    }
}
