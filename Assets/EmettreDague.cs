using UnityEngine;

public class EmettreDague : MonoBehaviour
{
    public GameObject dague;
    public GameObject boutique;
    public bool apparue = false;
    private float prochain_dague = 0f;

    private bool premiere_apparition = true;
    private float delai = 30f;

    void Start()
    {
    }

    void Update()
    {
        if (apparue == false && boutique.GetComponent<OnDeath>().maison_detruite == false)
        {
            if (premiere_apparition == true)
            {
                premiere_apparition = false;
                prochain_dague = Time.time + delai;
                return;
            }
            Debug.Log("Condition Update 1");
            if (Time.time >= prochain_dague)
            {
                Debug.Log("Condition Update 2");
                Apparition();
                apparue = true;
                prochain_dague = Time.time + delai;
            }

        }
    }
    
    void Apparition()
    {
        Instantiate(dague, transform.position, dague.transform.rotation).SetActive(true);
        prochain_dague = Time.time + delai;
    }
}
