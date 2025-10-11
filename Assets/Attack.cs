using UnityEngine;
using System.Collections;

public class Attac : MonoBehaviour
{
    public GameObject Projectile;
    public Transform Emitter;
    public float frequency;
    public int Number;

    void Start()
    {

    }

    void Update()
    {
        //Debug.DrawLine(Emitter.position, Vector, Color.red);
        
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        for (int i = 0; i < Number; i++)
        {
            GameObject Bullet = Instantiate(Projectile, Emitter.transform.position, Emitter.transform.rotation);
            Bullet.SetActive(true);
            Bullet.transform.GetComponent<Rigidbody>().AddForce(-10f * Emitter.transform.forward, ForceMode.Impulse);
            yield return new WaitForSeconds(frequency);
        }
    }
}
