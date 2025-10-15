using UnityEngine;

public class GestionDague : MonoBehaviour
{
    public GameObject joueur;
    public GameObject emeteurDague;
    private Attac attaque;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attaque = joueur.GetComponent<Attac>();
    }

    // Update is called once per frame
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
