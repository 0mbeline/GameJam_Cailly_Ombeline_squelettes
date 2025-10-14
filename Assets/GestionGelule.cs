using UnityEngine;

public class GestionGelule : MonoBehaviour
{
    public GameObject joueur;
    private SystemeDeSante sante_joueur;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sante_joueur = joueur.GetComponent<SystemeDeSante>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            int valeur = 20;
            Debug.Log("gelule gagnés ! ");
            sante_joueur.Heal(valeur);
            Destroy(gameObject);
        }
    }
}
