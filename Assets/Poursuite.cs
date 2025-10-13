using System.Runtime.CompilerServices;
using UnityEngine;

public class Poursuite : MonoBehaviour
{
    public GameObject Target;

    public GameObject Joueur;
    private const float VELOCITY = 0.2f;

    public GameObject batiments;

    private Vector3 vecteur;
    void Start()
    {
        vecteur = new Vector3(Random.Range(-5f,3f), 0f, Random.Range(-5f, 5f));
    }

    void Update()
    {
        if (Target != null)
        {
            Vector3 direction = Target.transform.position+vecteur - this.transform.position;
            direction.y = 0;

            transform.position += VELOCITY * direction / direction.magnitude;
            transform.rotation = Quaternion.LookRotation(-direction);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Aimant"))
        {
            //Debug.Log("Aimant touché");
            SelectBatiment();
        }
    }

    public void SelectBatiment()
    {
        int alea = Random.Range(0, 2);
        if (alea == 1)
        {
            Target = Joueur;
        }
        else{
            float min_distance = (float)1e50;
                foreach (Transform child in batiments.transform)
                {
                    SystemeDeSante target = Target.GetComponent<SystemeDeSante>();
                    if (child.gameObject.GetComponent<OnDeath>().maison_detruite || (target != null && !target.IsDead))
                    {
                        continue;
                    }
                    float distance = (transform.position - child.position).magnitude;
                    if (distance < min_distance)
                    {
                        min_distance = distance;

                        if (target != null)
                        {
                            target.OnchangedeSante -= ChangerCible;
                        }
                        Target = child.gameObject;
                        Target.GetComponent<SystemeDeSante>().OnchangedeSante += ChangerCible;
                    }
                }
        }
    }

    public void ChangerCible(float viebatiment)
    {
        //Debug.Log("ChangerCible"+viebatiment);
        if (viebatiment <= 0 && this!=null)
        {
            SelectBatiment();
        }
    }
    
}
