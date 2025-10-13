using UnityEngine;
using UnityEngine.UI;
public class AfficherPieceTexte : MonoBehaviour
{
    public Image imageArgent; // Image UI
    public Sprite nouvelleImage; // Sprite à afficher
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        imageArgent.sprite = nouvelleImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
