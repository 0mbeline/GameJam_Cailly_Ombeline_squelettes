using UnityEngine;

public class GestionArgent : MonoBehaviour
{
    public GameObject compteur;
    private CompteurGlobalArgent globalargent;
    void Start()
    {
        globalargent = compteur.GetComponent<CompteurGlobalArgent>();
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")||collision.gameObject.CompareTag("Gobelin"))
        {
            int valeur = 50;
            Debug.Log($"{valeur}€ gagnés ! ");
            globalargent.AjoutArgent(valeur);
            Destroy(gameObject);
        }
    }
    
}
