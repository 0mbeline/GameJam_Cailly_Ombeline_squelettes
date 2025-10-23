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

        if (health != null && !collision.gameObject.CompareTag("Player")&& !collision.gameObject.CompareTag("Maison")&& !collision.gameObject.CompareTag("Pharmacie"))
        {
            health.TakeDamage(10f);
            Destroy(gameObject);
        }
    }
}
