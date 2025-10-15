using UnityEngine;

public class EmettreMechants : MonoBehaviour
{
    public GameObject aggro;

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
        GameObject instance = Instantiate(aggro, transform.position, aggro.transform.rotation);
        instance.SetActive(true);
    }
    else
    {
        Debug.LogWarning("'aggro' non assigné ou détruit !");
    }
}

}
