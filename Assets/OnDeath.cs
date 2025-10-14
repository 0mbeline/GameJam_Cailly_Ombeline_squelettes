using UnityEngine;

public class OnDeath : MonoBehaviour
{
    public SystemeDeSante Sante;
    public Canvas deathCanvas;

    public bool maison_detruite = false;

    public GameObject piece;
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
        var temps_avant_disparition = 0.2f;
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
        int alea = Random.Range(0, 10);
        Debug.Log(alea);
        if (alea%3!=0)
        {
            for (int i = 0; i < alea; i++)
            {
                Invoke("Apparition", 0f);
            }
        }
        Destroy(gameObject, temps_avant_disparition);
        

    }

    void Apparition()
    {
        Instantiate(piece, transform.position, piece.transform.rotation).SetActive(true);
    }
    
    private void displayudied()
    {
        if (deathCanvas != null)
        {
            deathCanvas.gameObject.SetActive(true);
        }
    }
}
