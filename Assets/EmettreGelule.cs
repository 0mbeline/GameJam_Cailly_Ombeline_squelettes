using UnityEngine;

public class EmettreGelule : MonoBehaviour
{
    public GameObject gelule;
    public bool apparue = false;

    private float prochain_gelule;
    public float delai = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Apparition();
        apparue = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (apparue == false)
        {
            Apparition();
            apparue = true;
        }
    }
    
    void Apparition()
    {
        if (Time.time < prochain_gelule) return;
        Instantiate(gelule, transform.position, gelule.transform.rotation).SetActive(true);
        prochain_gelule = Time.time + delai;
    }
}
