using UnityEngine;

public class GestionGelule : MonoBehaviour
{
    public GameObject joueur;
    public GameObject emmeteurgelule;

    public GameObject pharmacie;
    private SystemeDeSante sante_joueur;
    void Start()
    {
        sante_joueur = joueur.GetComponent<SystemeDeSante>();
    }

    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            int valeur = 20;
            Debug.Log("gelule gagnée ! ");
            sante_joueur.Heal(valeur);
            if (pharmacie!=null) {
                emmeteurgelule.GetComponent<EmettreGelule>().apparue = false;
            }
            Destroy(gameObject);
        }
    }
}
