using UnityEngine;

public class EmettreGelule : MonoBehaviour
{
    public GameObject gelule;
    private bool apparue = false;
    public float delai = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Apparition", 0, delai);
        apparue = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (apparue == false)
        {
            InvokeRepeating("Apparition", 0, delai);
            apparue = true;
        }
    }
    
    void Apparition()
    {
        Instantiate(gelule, transform.position, gelule.transform.rotation).SetActive(true);   
    }
}
