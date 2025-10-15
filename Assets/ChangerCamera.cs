using UnityEngine;

public class ChangerCamera : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Camera_sur_Joueur;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
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
