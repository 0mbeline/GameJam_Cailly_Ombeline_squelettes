using UnityEngine;

public class EmettreMechants : MonoBehaviour
{
    public GameObject aggro;
    public GameObject fantome;
    public float delai;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Apparition", 0, delai);
    }
    
    // void Apparition()
    // {
    //     Instantiate(aggro, transform.position, aggro.transform.rotation).SetActive(true);   
    // }
    void Apparition()
{
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
