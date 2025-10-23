using UnityEngine;
using UnityEngine.UI;
public class AfficherPieceTexte : MonoBehaviour
{
    public Image imageArgent; // Image UI
    public Sprite nouvelleImage; // Sprite à afficher
    void Start()
    {
        imageArgent.sprite = nouvelleImage;
    }
    void Update()
    {
        
    }
}
