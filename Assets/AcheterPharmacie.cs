using UnityEngine;

public class AcheterPharmacie : MonoBehaviour
{

    public GameObject pharmacie;
    public GameObject compteur;
    private CompteurGlobalArgent globalargent;
    //public bool maison_detruite = true;
    private int prix = 10;

    private int argent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pharmacie.SetActive(false);
    }

    // Update is called once per frame
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
            pharmacie.GetComponent<OnDeath>().maison_detruite = false;
            pharmacie.SetActive(true);
            Destroy(gameObject);
        }
    }
    
    // void OnTriggerEnter(Collider collider)
    // {
    //     if (collider.gameObject.CompareTag("Player"))
    //     {
    //         //Debug.Log("Aimant touché");
    //         SelectBatiment();
    //     }
    // }
}

