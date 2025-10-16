using UnityEngine;

public class CompteurGlobalArgent : MonoBehaviour
{
    [SerializeField] private int argent;
    void Start()
    {

    }

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

    public void RetirerArgent(int valeur)
    {
        argent -= valeur;
    }
}
