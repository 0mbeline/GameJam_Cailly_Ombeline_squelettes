using UnityEngine;

public class AcheterBoutiqueDague : MonoBehaviour
{
    public GameObject boutique;
    public GameObject compteur;
    private CompteurGlobalArgent globalargent;
    private int prix = 2000;

    private int argent;
    void Start()
    {
        boutique.SetActive(false);
    }

    void Update()
    {
        globalargent = compteur.GetComponent<CompteurGlobalArgent>();
        argent = globalargent.GetArgent();


    }
    private void OnTriggerEnter(Collider collider)
    {
        if (boutique == null) return;
        Debug.Log("collision");
        if (collider.gameObject.CompareTag("Player") && argent >= prix)
        {
            globalargent.RetirerArgent(prix);
            boutique.GetComponent<OnDeath>().maison_detruite = false;
            boutique.SetActive(true);
            Destroy(gameObject);
        }
    }
}
