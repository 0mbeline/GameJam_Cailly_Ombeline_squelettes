using UnityEngine;

public class EmettreGelule : MonoBehaviour
{
    public GameObject gelule;
    public GameObject pharmacie;
    public bool apparue = false;
    private float prochain_gelule = 0f;

    private bool premiere_apparition = true;
    public float delai;

    void Start()
    {
    }

    void Update()
    {
        if (apparue == false && pharmacie.GetComponent<OnDeath>().maison_detruite == false)
        {
            if (premiere_apparition == true)
            {
                premiere_apparition = false;
                prochain_gelule = Time.time + delai;
                return;
            }
            Debug.Log("Condition Update 1");
            if (Time.time >= prochain_gelule)
            {
                Debug.Log("Condition Update 2");
                Apparition();
                apparue = true;
                prochain_gelule = Time.time + delai;
            }

        }

    }
    
    void Apparition()
    {
        Instantiate(gelule, transform.position, gelule.transform.rotation).SetActive(true);
        prochain_gelule = Time.time + delai;
    }
}
