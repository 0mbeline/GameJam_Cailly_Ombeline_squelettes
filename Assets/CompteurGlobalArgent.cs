using UnityEngine;

public class CompteurGlobalArgent : MonoBehaviour
{
    [SerializeField] private int argent = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void AjoutArgent(int valeur)
    {
        argent += valeur;
    }
    public int GetArgent()
{
    return argent;
}
}
