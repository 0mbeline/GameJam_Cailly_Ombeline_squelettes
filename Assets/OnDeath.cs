using UnityEngine;

public class OnDeath : MonoBehaviour
{
    public SystemeDeSante Sante;
    public Canvas deathCanvas;

    void Start()
    {
        
    }

    void Update()
    {
        if (Sante != null && Sante.IsDead)
        {
            udied();
            displayudied();
        }
    }

    private void udied()
    {
        var temps_avant_disparition = 2f;
        var rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = false;
            rb.constraints = RigidbodyConstraints.None;
        }
        if(CompareTag("Player")){
            temps_avant_disparition += 3f;
        }
        Destroy(gameObject, temps_avant_disparition);
    }

    private void displayudied()
    {
        if(deathCanvas != null)
        {
            deathCanvas.gameObject.SetActive(true);    
        }
    }
}
