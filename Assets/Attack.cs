using UnityEngine;
using System.Collections;

public class Attac : MonoBehaviour
{
    public GameObject Projectile;
    public Transform Emitter;
    public float frequency;
    private int Number = 1;

    void Start()
    {

    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        for (int i = 0; i < Number; i++)
        {
            GameObject Bullet = Instantiate(Projectile, Emitter.transform.position, Quaternion.Euler(90f, 0f, 90f) * Emitter.transform.rotation);
            Bullet.SetActive(true);
            Bullet.transform.GetComponent<Rigidbody>().AddForce(-50f * Emitter.transform.forward, ForceMode.Impulse);
            yield return new WaitForSeconds(frequency);
        }
    }
    
    public void ajouterNumber(int nombre)
    {
        Number += nombre;
    }
}
