using UnityEngine;

public class ChangerCamera : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Camera_sur_Joueur;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (MainCamera.activeSelf)
            {
                MainCamera.SetActive(false);
                Camera_sur_Joueur.SetActive(true);
            }
            else
            {
                MainCamera.SetActive(true);
                Camera_sur_Joueur.SetActive(false);
            }
        }
        
    }
}
