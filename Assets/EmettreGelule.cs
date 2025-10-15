using UnityEngine;

public class EmettreGelule : MonoBehaviour
{
    public GameObject gelule;
    public GameObject pharmacie;
    public bool apparue = false;

    private float prochain_gelule=0f;
    public float delai = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (apparue == false && pharmacie.GetComponent<OnDeath>().maison_detruite==false)
        {
            prochain_gelule = Time.time + delai;
            if (Time.time >= prochain_gelule)
            {
                Debug.Log("Condition Update");
                Apparition();
                apparue = true;
            }
        }
    }
    
    void Apparition()
    {
        Instantiate(gelule, transform.position, gelule.transform.rotation).SetActive(true);
        prochain_gelule = Time.time + delai;
    }
}
