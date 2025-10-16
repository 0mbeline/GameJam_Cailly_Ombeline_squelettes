using UnityEngine;

public class EmettreMechants : MonoBehaviour
{
    public GameObject aggro;
    public GameObject fantome;
    private float delai = 2f;
    private int nombre_ennemis_sortis=0;
    void Start()
    {
        InvokeRepeating("Apparition", 0, delai);
    }
    
    void Apparition()
    {
        if (nombre_ennemis_sortis > 10)
        {
            delai *= 0.7f;
        }
        nombre_ennemis_sortis++;
    if (aggro != null)
        {
            int alea = Random.Range(0, 5);
            if (alea < 3)
            {
                GameObject instance = Instantiate(aggro, transform.position, aggro.transform.rotation);
                instance.SetActive(true);
            }
            else
            {
                GameObject instance = Instantiate(fantome, transform.position, fantome.transform.rotation);
                instance.SetActive(true);
            }
    }
    else
    {
        Debug.LogWarning("'aggro' non assigné ou détruit !");
    }
}

}
