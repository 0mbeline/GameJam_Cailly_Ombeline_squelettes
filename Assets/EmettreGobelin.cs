using UnityEngine;

public class EmettreGobelin : MonoBehaviour
{
    public GameObject gobelin;
    public GameObject hutte;
    public bool apparue = false;
    private float delai = 5f;

    void Start()
    {
    }

    void Update()
    {
        if (apparue == false && hutte.GetComponent<OnDeath>().maison_detruite == false)
        {
            Apparition();
            
            apparue = true;
        }
    }

    void Apparition()
    {
        Instantiate(gobelin, transform.position, gobelin.transform.rotation).SetActive(true);
        Invoke("Apparition2", delai);
    }
    
    void Apparition2()
    {
        Instantiate(gobelin, transform.position, gobelin.transform.rotation).SetActive(true);
    }
}
