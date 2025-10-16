using UnityEngine;

public class GestionDague : MonoBehaviour
{
    public GameObject joueur;
    public GameObject emeteurDague;
    private Attac attaque;
    void Start()
    {
        attaque = joueur.GetComponent<Attac>();
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("épée gagnée ! ");
            attaque.ajouterNumber(1);
            emeteurDague.GetComponent<EmettreDague>().apparue = false;
            Destroy(gameObject);
        }
    }
}
