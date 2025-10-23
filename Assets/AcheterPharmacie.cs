using UnityEngine;

public class AcheterPharmacie : MonoBehaviour
{

    public GameObject pharmacie;
    public GameObject compteur;
    private CompteurGlobalArgent globalargent;
    private int prix = 400;

    private int argent;
    void Start()
    {
        pharmacie.SetActive(false);
    }

    void Update()
    {
        globalargent = compteur.GetComponent<CompteurGlobalArgent>();
        argent = globalargent.GetArgent();


    }
    private void OnTriggerEnter(Collider collider)
    {
        if (pharmacie == null) return;
        Debug.Log("collision");
        if (collider.gameObject.CompareTag("Player") && argent >= prix)
        {
            globalargent.RetirerArgent(prix);
            pharmacie.GetComponent<OnDeath>().maison_detruite = false;
            pharmacie.SetActive(true);
            Destroy(gameObject);
        }
    }
    
}

