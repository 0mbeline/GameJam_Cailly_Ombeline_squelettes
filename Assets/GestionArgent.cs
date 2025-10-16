using UnityEngine;

public class GestionArgent : MonoBehaviour
{
    public GameObject compteur;
    private CompteurGlobalArgent globalargent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        globalargent = compteur.GetComponent<CompteurGlobalArgent>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")||collision.gameObject.CompareTag("Gobelin"))
        {
            int valeur = 10;
            Debug.Log($"{valeur}€ gagnés ! ");
            globalargent.AjoutArgent(valeur);
            Destroy(gameObject);
        }
    }
    
}
