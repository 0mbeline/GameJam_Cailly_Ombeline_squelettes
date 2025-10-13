using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ChangementArgent : MonoBehaviour
{
    private TextMeshProUGUI argentTexte;
    public GameObject compteur;
    private CompteurGlobalArgent globalargent;

    // public Image imageArgent; // Image UI
    // public Sprite nouvelleImage; // Sprite à afficher
    void Start()
    {
        globalargent = compteur.GetComponent<CompteurGlobalArgent>();
        argentTexte = GameObject.Find("CompteurArgent").GetComponent<TextMeshProUGUI>();
        // imageArgent.sprite = nouvelleImage;
    }

    void Update()
    {
        argentTexte.text = "" + globalargent.GetArgent();
    }
}