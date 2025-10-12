using UnityEngine;
using TMPro;
public class ChangementArgent : MonoBehaviour
{
    private TextMeshProUGUI argentTexte;
    public GameObject compteur;
    private CompteurGlobalArgent globalargent;
    void Start()
    {
        globalargent = compteur.GetComponent<CompteurGlobalArgent>();
        argentTexte = GameObject.Find("CompteurArgent").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        argentTexte.text = "Argent :" + globalargent.GetArgent() + "€";
    }
}
