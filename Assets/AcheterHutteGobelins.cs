using UnityEngine;

public class AcheterHutteGobelins : MonoBehaviour
{
    public GameObject hutte;
    public GameObject compteur;
    private CompteurGlobalArgent globalargent;
    //public bool maison_detruite = true;
    private int prix = 20;

    private int argent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hutte.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        globalargent = compteur.GetComponent<CompteurGlobalArgent>();
        argent = globalargent.GetArgent();


    }
    private void OnTriggerEnter(Collider collider)
    {
        if (hutte == null) return;
        Debug.Log("collision");
        if (collider.gameObject.CompareTag("Player") && argent >= prix)
        {
            globalargent.RetirerArgent(prix);
            hutte.GetComponent<OnDeath>().maison_detruite = false;
            hutte.SetActive(true);
            Destroy(gameObject);
        }
    }
}
