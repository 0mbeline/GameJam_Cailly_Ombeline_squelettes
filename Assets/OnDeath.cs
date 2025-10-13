using UnityEngine;

public class OnDeath : MonoBehaviour
{
    public SystemeDeSante Sante;
    public Canvas deathCanvas;

    public bool maison_detruite=false;

    void Start()
    {
        if(Sante != null)
        {
            Sante.OnchangedeSante += Mort;
        }
    }

    private void Mort(float vie)
    {
        if (vie > 0)
        {
            return;
        }
        if (Sante != null && Sante.IsDead)
        {
            if (CompareTag("Maison")||CompareTag("Pharmacie"))
            {
                maison_detruite = true;
                //GetComponent<BoxCollider>().enabled=false;
                gameObject.SetActive(false);
                return;
            }
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
        if (CompareTag("Player"))
        {
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
